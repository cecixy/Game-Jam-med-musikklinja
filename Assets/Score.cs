using UnityEngine;

public class Score : MonoBehaviour {

    public int score;

    void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + score);
            Destroy(gameObject);
    }

}
