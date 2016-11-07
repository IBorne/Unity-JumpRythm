using UnityEngine;
using System.Collections;

public class ChaScript : MonoBehaviour
{

    private Animator anim;
    public CharacterController controller;
    public float vertical_velocity;
    public float gravity = 14.0f;
    public float jumpForce = 10.0f;

    

    void Start()
    {
        anim = GetComponent<Animator>();
       /* controller = GetComponent<CharacterController>();
 */   }

    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = false;

    }

    void Update()
    {
    /*    if (controller.isGrounded)
        {
            vertical_velocity = -gravity * Time.deltaTime;
            if (Input.GetKey(KeyCode.J))
            {
                vertical_velocity = jumpForce;
            }


        }
        else
        {
            vertical_velocity -= gravity * Time.deltaTime;
        }

        Vector3 moveVector = new Vector3(0, vertical_velocity, 0);
        controller.Move(moveVector * Time.deltaTime);


   */     if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("RunLeft", true);
            float translation = Time.deltaTime * 10;
            transform.Translate(translation, 0, 0);
        }
        else
        {
            anim.SetBool("RunLeft", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("RunBack", true);
            
            float translation = Time.deltaTime * 10;
            transform.Translate(0, 0, -translation);
        }
        else
        {
            anim.SetBool("RunBack", false);
            
            
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Run", true);
            
            float translation = Time.deltaTime * 10;
            transform.Translate(0, 0, translation);
        }
        else
        {
            anim.SetBool("Run", false);
            
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            anim.SetBool("RunRight", true);
            float translation = Time.deltaTime * 10;
            transform.Translate(-translation, 0, 0);
        }
        else
        {
            anim.SetBool("RunRight", false);
            
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);
        }



    }


}
