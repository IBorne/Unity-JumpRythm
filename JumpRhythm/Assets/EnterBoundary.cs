using UnityEngine;
using System.Collections;

public class EnterBoundary : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {      
        if( other.gameObject.tag == "Slime" && Input.GetKey(KeyCode.Space))
        {
            Destroy(other.gameObject);
        }
    }
}
