using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChaScript : MonoBehaviour
{
    private Animator anim;
    private float vertical_velocity;
    public float gravity = 45f;
    public float jumpforce = 20f;
    public float speed = 11f;
    public Rigidbody rb;
    bool GO = false;

    public Text countText;
    private int count;

    void Start()
    {
        count = 0;
        SetCountText();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = false;
        if (other.gameObject.CompareTag("Box_Slime"))
        {
            other.gameObject.SetActive(false);
            count += 20;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Score :" + count.ToString();
    }
    void Update()
    {
        //gestion du mouvement
        if (Time.timeSinceLevelLoad > 1)
        {
            GO = true;
        }

        if (GO)
        {
            anim.SetBool("Run", true);
            float translation = Time.deltaTime * speed;
            transform.Translate(0, 0, translation);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Run", false);
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);
            anim.SetBool("Run", true);
        }
        //destrucution des ennemies
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(transform.position.y <= 2f)
            {
                vertical_velocity = jumpforce;
            }
        }      
        else
        {
            vertical_velocity -= gravity * Time.deltaTime;
            if(vertical_velocity < -45f)
            {
                vertical_velocity = -gravity;
            }
        }
        rb.AddForce(0, vertical_velocity, 0, ForceMode.VelocityChange);

    }


}
