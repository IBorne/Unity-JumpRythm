using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseScript : MonoBehaviour {
    public static bool paused;
    public void Pause()
    {
        paused = !paused;
        if (paused)
        {
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            Time.timeScale = 1;
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            GameObject.Find("Canvas").transform.GetChild(1).gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(true);
            Pause();
        }
    }     
}
