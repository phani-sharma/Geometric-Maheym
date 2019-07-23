using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenu;

    public void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                pause();
            }
        }
       

    }


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void quitApplication()
    {
        Application.Quit();
        Debug.Log("exited application");
    }

    public void restaet()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
       // SceneManager.LoadScene(1);
        //gameoverScreen.SetActive(false);
    }
    //public GameObject loadingScreen;
    //public Slider LoadingBar;

    //public void playGame(int sceneIndex)
    //{

    //    StartCoroutine(LoadAsync(sceneIndex));

    //}



    //IEnumerator LoadAsync(int sceneindex)
    //{
    //    AsyncOperation operation = SceneManager.LoadSceneAsync(sceneindex);

    //    loadingScreen.SetActive(true);

    //    while(!operation.isDone)
    //    {
    //        float progress = Mathf.Clamp01(operation.progress / .9f);
    //        Debug.Log(progress);
    //        LoadingBar.value = progress;
    //    }
    //    yield return null;
    //}

    //public void Exit()
    //{
    //    Application.Quit();
    //}

    public void Resume()
    {
        soundManager.instance.musicSource.Play();
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void pause ()
    {
        soundManager.instance.musicSource.Pause();
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void MainMEnu()
    {
        soundManager.instance.musicSource.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
