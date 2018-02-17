using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public AudioSource missionFailedSound;

    public GameObject PauseMenuUi;
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
	}

    public void Resume()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        GameIsPaused = false;
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
