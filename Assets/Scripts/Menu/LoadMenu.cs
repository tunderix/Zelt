using UnityEngine.SceneManagement;

public class LoadMenu : ZeltBehaviour
 
{

    public void GoToMenu ()
    {
        SceneManager.LoadScene("Menu");
    }
}
