using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPos : MonoBehaviour
{
    public Rigidbody2D player;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("in col");
        player.transform.localRotation = Quaternion.AngleAxis(180f, Vector3.forward);
    }
}
