using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Rigidbody2D player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rat")
        {
            Destroy(collision.gameObject);
            FindObjectOfType<manager>().ScoreIncrement();
        }
        if (collision.gameObject.tag == "dog")
        {
            Destroy(collision.gameObject);
            FindObjectOfType<manager>().LifeDecrement();
        }
        if (collision.gameObject.name == "Wall")
        {
            float force = 3;
            Vector2 dir = collision.contacts[0].point - new Vector2 (transform.position.x,transform.position.y);
            dir = -dir.normalized;
            player.AddForce(dir * force);
            //FindObjectOfType<joystick>().resetRotation = true;
            transform.rotation = Quaternion.AngleAxis(transform.eulerAngles.z + 180f,Vector3.forward);
        }
    }
}
