using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactEffectController : MonoBehaviour
{
    void Start()

    {
        StartCoroutine(destroyOverTime());
    }

    public IEnumerator destroyOverTime()

    {
        // Aika, jonka jälkeen impact-effect tuhotaan.
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);

    }
}
