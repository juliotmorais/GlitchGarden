using System.Collections;
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
    private void LoadStartScreen()
    {
        
        SceneManager.LoadScene(1);
    }
    public void LoadStartScreenFromSplashScreen()
    {
        StartCoroutine(LoadStartScreenWithDelay());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadStartScreenWithDelay()
    {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
