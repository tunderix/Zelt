using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneJumper : MonoBehaviour
{
    public void GoToGameScene()
    {
        //TODO - Constant in here instead of string. 
        SceneManager.LoadScene("GameLevel", LoadSceneMode.Single);
    }
    public void GoToMenu()
    {
        //TODO - Constant in here instead of string. 
        SceneManager.LoadScene("GameMenu", LoadSceneMode.Single);
    }
}
