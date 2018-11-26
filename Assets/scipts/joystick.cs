using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed = 3.0f;
    //private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;
    private float baseAngle = 0.0f;
    private float CircleCurrAngle = 0.0f;
    public bool resetRotation = false;
    public Transform circle;
    
    void Update()
    {
        if (resetRotation == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 dir = Camera.main.WorldToScreenPoint(transform.position);
                dir = Input.mousePosition - dir;
                baseAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                baseAngle -= Mathf.Atan2(transform.right.y, transform.right.x) * Mathf.Rad2Deg;
                CircleCurrAngle = player.transform.eulerAngles.z;
            }
            if (Input.GetMouseButton(0))
            {
                var dir = Camera.main.WorldToScreenPoint(transform.position);
                dir = Input.mousePosition - dir;
                var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - baseAngle;
                circle.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                Debug.Log(angle);
                moveCharacter(angle + CircleCurrAngle);
            }
            else
            {
                circle.eulerAngles = new Vector3(0f, 0f, 0f);
                //touchStart = false;
            }
        }
        else
            resetRotation = false;

    }
    private void FixedUpdate()
    {
        player.transform.Translate( Vector2.up * speed * Time.fixedDeltaTime);
    }
    void moveCharacter(float angle)
    {
        player.transform.localRotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}