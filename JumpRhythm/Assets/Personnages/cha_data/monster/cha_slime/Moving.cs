using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {
    private Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
            anim.SetBool("Walk", true);
            float translation = Time.deltaTime * 2;
            transform.Translate(-translation, 0, 0);
    }
}
