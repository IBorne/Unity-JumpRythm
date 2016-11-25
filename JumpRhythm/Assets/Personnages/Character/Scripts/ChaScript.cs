using UnityEngine;
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

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = false;

    }

    void Update()
    {

        if (Time.timeSinceLevelLoad > 0.7465)
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
