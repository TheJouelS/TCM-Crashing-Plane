using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollector : MonoBehaviour
{
    private static int numMonedes = 0;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            numMonedes++;
            Debug.Log(numMonedes);
            Destroy(this.gameObject);
        }
    }
}
