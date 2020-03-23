using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionHoleMove : LazerObject
{
    public float FL_rotateSpeed = -15.0f;
    public float yaw = 0.0f;
    public bool isDragged;

    public void Start()
    {
        base.Start();
    }

    public void Update()
    {

        base.Update();

        if (Input.touchCount != 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                bool isTouch = GetComponent<Collider2D>().OverlapPoint(Camera.main.ScreenToWorldPoint(touch.position));
                isDragged = isTouch;
            }
        }
        else
        {
            isDragged = false;
        }
        if (Input.touchCount > 0 && isDragged)
        {
            yaw = yaw + Input.GetTouch(0).deltaPosition.x * FL_rotateSpeed * Time.deltaTime;
            this.transform.eulerAngles = new Vector3(0.0f, 0.0f, yaw);
        }
    }
}
