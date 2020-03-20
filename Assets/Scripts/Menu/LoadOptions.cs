using UnityEngine.SceneManagement;

public class LoadOptions : ZeltBehaviour
 
{

    public void GoToOptions ()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
}