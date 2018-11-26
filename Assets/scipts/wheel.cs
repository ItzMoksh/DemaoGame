using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel : MonoBehaviour
{
    public Transform player;
    public float speed = 20.0f;
    private bool screenTouch = false;
    private Vector2 pointA;
    private Vector2 pointB;
    public Transform innerCircle;
    public Transform outerCirlce;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        if (Input.GetMouseButton(0))
        {
            screenTouch = true;
            pointB = Camera.main.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {

            screenTouch = false;
        }
    }
    private void FixedUpdate()
    {
        if (screenTouch)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            CharacterControl(direction);
            innerCircle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y);
        }
        else
        {
            innerCircle.GetComponent<SpriteRenderer>().enabled = false;
            outerCirlce.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    void CharacterControl(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
    }
}
