using UnityEngine.SceneManagement;
using System;

public class SceneJumper : ZeltBehaviour
{
    public void GoTo(String scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
