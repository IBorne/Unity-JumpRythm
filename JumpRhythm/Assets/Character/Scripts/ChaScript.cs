using UnityEngine;
using System.Collections;

public class ChaScript : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Run", true);
            float translation = Time.deltaTime * 10;
            transform.Translate(0, 0, translation);
        }
        else
        {
            anim.SetBool("Run", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("RunLeft", true);
            float translation = Time.deltaTime * 10;
            transform.Translate(-translation, 0, 0);
        }
        else
        {
            anim.SetBool("RunLeft", false);
            
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("RunRight", true);
            float translation = Time.deltaTime * 10;
            transform.Translate(translation, 0, 0);
        }
        else
        {
            anim.SetBool("RunRight", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("RunBack", true);
            float translation = Time.deltaTime * 10;
            transform.Translate(0, 0, -translation);
        }
        else
        {
            anim.SetBool("RunBack", false);
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
