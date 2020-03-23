using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDrag : MonoBehaviour
{

    private float FL_rotateSpeed = -15.0f;
    private float yaw = 0.0f;
    private bool isDragged;

    private void Update()
    {
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

            //this.transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            touchPosition.z = 0;
            this.transform.position = touchPosition;
        }
    }
}
