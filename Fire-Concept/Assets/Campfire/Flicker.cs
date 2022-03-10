using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Flicker : MonoBehaviour
{
   
    void Start()
    {
       StartCoroutine(FlickeringLight());
    }

    IEnumerator FlickeringLight()
    {
        while(true)
        {
        yield return new WaitForSeconds(Random.Range(0.05f, 0.2f));
        this.gameObject.GetComponent<Light>().enabled = false;

        yield return new WaitForSeconds(Random.Range(0.05f, 0.4f));
        this.gameObject.GetComponent<Light>().enabled = true;
        }
    }
}
