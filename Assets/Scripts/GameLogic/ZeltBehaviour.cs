using UnityEngine;

public class ZeltBehaviour : MonoBehaviour
{
    protected GameController GameController
    {
        get
        {
            return GameObject.FindGameObjectWithTag("GOD").GetComponent<GameController>();
        }
    }
}
