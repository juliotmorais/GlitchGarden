﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int currentSceneIndex;
    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            LoadStartScreenFromSplashScreen();
        }

    }
    public void LoadSplashScreen()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadStartScreen()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void LoadStartScreenFromSplashScreen()
    {
        StartCoroutine(LoadStartScreenWithDelay());
    }
    public void LoadOptionsScreen()
    {
        SceneManager.LoadScene(3);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
    IEnumerator LoadStartScreenWithDelay()
    {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
    public void LoseScreen()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadGamePlay()
    {
        SceneManager.LoadScene(2);
    }
}
