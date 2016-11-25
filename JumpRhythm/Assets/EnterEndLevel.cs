using UnityEngine;
using System.Collections;

public class EnterEndLevel : MonoBehaviour
{
    GameObject end;

    public void OnTriggerEnter(Collider other)
    {
        end = GameObject.Find("Canvas").transform.GetChild(1).gameObject;
        end.SetActive(true);
        Time.timeScale = 0f;
    }
}
