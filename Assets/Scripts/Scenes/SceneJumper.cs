using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class SceneJumper : MonoBehaviour
{
    public void GoTo(String scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
