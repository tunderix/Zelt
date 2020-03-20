using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleObject : ZeltBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        KeyCode jumpKey = this.GameController.InputController.jumpKey;
        Debug.Log("The jumpkey of the game is: " + jumpKey);

        string inputControllerName = ((ZeltController)this.GameController.InputController).controllerName;
        Debug.Log("The input controller name is: " + inputControllerName);
    }
}
