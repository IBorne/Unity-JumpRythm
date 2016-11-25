using UnityEngine;
using System.Collections;

public class EnterBoundary : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {      
        if(GameObject.Find("Cha_Slime").GetComponent<Collider>() == other && Input.GetKey(KeyCode.Space))
        {
            Destroy(other.gameObject);
        } 
    }
}
