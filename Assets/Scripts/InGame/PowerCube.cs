using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCube : LazerObject
{

    public GameObject Power;
    public GameObject PowerCubeLaser;

    public float Speed;
    //private Rigidbody2D rb;
    private Touch TempTouchs;
    private Vector3 touchPos;
    private bool touchOn;

    public GameObject dir;

    Vector3 pos = Vector3.zero;//



    private float FL_rotateSpeed = -15.0f;
    private float yaw = 0.0f;
    private bool isDragged;

    public void Start()
    {
        base.Start();   
        PowerCubeLaser.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {

        base.Update();
     //   Debug.Log(isReceive);
        if (isReceive)
        {
            PowerCubeLaser.SetActive(true);
            //var master = receiveFrom.GetComponent<Master>();
            //if(master is LazerObject)
            //{
            //    LazerObject lazer = (LazerObject)master;
            //    GetComponentInChildren<LineRenderer>().material = lazer.selectedColor;
            //}
           
        }
        else{
            PowerCubeLaser.SetActive(false);
        }

       
            if(Input.touchCount != 0)
            {
                Touch touch = Input.GetTouch(0);
                if(touch.phase == TouchPhase.Began)
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

