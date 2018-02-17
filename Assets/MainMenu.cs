using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

    public AudioSource missionFailedSound;

	public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    public void QuitGame()
    {
        Debug.Log("Mission Failed....");
        StartCoroutine(MissionFailed());
        missionFailedSound.Play();
    }

    IEnumerator MissionFailed()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("YOU JUST QUIT THE GAME!");
        Application.Quit();
    }

}
