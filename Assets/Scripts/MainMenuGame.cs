using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuGame : MonoBehaviour 
{

    public void PlayGame ()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}

