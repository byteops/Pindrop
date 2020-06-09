using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{  
    public void PlayGame()
    {
        SceneManager.LoadScene("Main Level" );
    }
    
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    
    public void GoToSettingMenu()
    {
        SceneManager.LoadScene("SettingMenu");

    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void goback()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
