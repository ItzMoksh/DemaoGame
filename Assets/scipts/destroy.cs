using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision collision)
    {
        Debug.Log("ENTERED");
        Destroy(gameObject);
    }
}
