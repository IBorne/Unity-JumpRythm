using UnityEngine;
using System.Collections;

public class Music_pause : MonoBehaviour {

    AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (PauseScript.paused)
        {
            audio.Pause();
        }
        else
        {
            audio.UnPause();
        }
	}
}
