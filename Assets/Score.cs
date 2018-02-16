using UnityEngine;

public class Score : MonoBehaviour {

    public int score;


    void OnTriggerEnter(Collider other)
    {
		FindObjectOfType<AudioManager> ().Play ("Ploop"); 
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + score);
            Destroy(gameObject);
    }

}
