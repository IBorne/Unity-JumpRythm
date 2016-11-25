using UnityEngine;
using System.Collections;

public class BeatMeasure : MonoBehaviour {

    AudioSource audio;
    
	void Start () {
        audio = GetComponent<AudioSource>();
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == GameObject.Find("JellyFishGirl"))
        {
            audio.Play();
        }
    }
}
