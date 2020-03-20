using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOptions : MonoBehaviour
 
{

    public void GoToOptions ()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
}