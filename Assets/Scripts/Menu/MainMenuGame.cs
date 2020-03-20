using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuGame : ZeltBehaviour 
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

