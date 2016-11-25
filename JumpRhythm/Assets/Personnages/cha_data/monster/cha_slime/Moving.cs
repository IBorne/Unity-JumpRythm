using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {
    float damage = 5f;
    public GUIText scoreText;
    public int score;
    // Use this for initialization
    void Start () {
        score = 0;
        UpdateScore();
    }
	
	// Update is called once per frame
	void Update () {
            float translation = Time.deltaTime * 2;
            transform.Translate(0, 0, -translation);
    }
    void OnCollisionEnter(Collider other)
    {
        other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
    }
    public void AddScore(int newScoreValue)
    {
        score = newScoreValue;
        UpdateScore();
    }
    void UpdateScore()
    {
        scoreText.text = "Score" + score;
    }
}
