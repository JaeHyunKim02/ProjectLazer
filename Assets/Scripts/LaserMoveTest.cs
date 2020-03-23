using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMoveTest : MonoBehaviour
{


    private float FL_rotateSpeed = -15.0f;
    private float yaw = 0.0f;
    private bool isDragged;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
            this.transform.eulerAngles = new Vector3(0.0f, 0.0f, yaw);
            yaw = yaw + Input.GetTouch(0).deltaPosition.y * FL_rotateSpeed * Time.deltaTime;
            this.transform.eulerAngles = new Vector3(yaw, yaw, 0.0f);
        }
        
    }
}
