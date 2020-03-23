using eageramoeba.Lasers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LazerObject : Master
{
    laser laserProjector;
    [SerializeField]
    public LaserColor color = LaserColor.WHITE;
    public Material selectedColor;
    public Material[] colors;
    [SerializeField]
    [Serializable]
    public enum LaserColor
    {
        WHITE = 0,
        RED,
        GREEN,
        BLUE,
    }

    private float FL_rotateSpeed = -15.0f;
    private float yaw = 0.0f;
    private bool isDragged;
    public laser linkedLaser;
    public GameObject hit;
    public Master hasMaster;
    // Start is called before the first frame update
    protected void Start()
    {
        laserProjector = gameObject.GetComponentInChildren<laser>();

        //selectedColor = colors[color.GetHashCode()];
        //GetComponentInChildren<LineRenderer>().material = colors[color.GetHashCode()];
    }

    // Update is called once per frame
    protected void Update()
    {
        base.Update();
        if(laserProjector == null)
        {
            laserProjector = gameObject.GetComponentInChildren<laser>();
        }
        if (laserProjector.onM != laserProjector.gameObject.activeSelf)
        {
            laserProjector.onM = laserProjector.gameObject.activeSelf;
        }
        linkedLaser = laserProjector;

        while (linkedLaser.directChild != null)
        {
            linkedLaser = linkedLaser.directChild.GetComponentInChildren<laser>();
        }
        hit = linkedLaser.hitGO;
        if (hit != null)
        {
            hasMaster = hit.GetComponentInChildren<Master>();
            if (hasMaster != null)
            {
                hasMaster.isReceive = true;
                hasMaster.receiveFrom = this.gameObject;
            }
        }
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

        float laserX = linkedLaser.GetComponentInChildren<LineRenderer>().GetPosition(1).x;//x
        float laserY = linkedLaser.GetComponentInChildren<LineRenderer>().GetPosition(1).y;//y
        float m_thisX = 0;
        float m_thisY = 0;

        if (isReceive)
        {
            m_thisX = receiveFrom.transform.position.x;//x2
            m_thisY = receiveFrom.transform.position.y;//y2
        }
        //Debug.Log(laserX + "," + laserY + "," + m_thisX + "," + m_thisY);

        float Width;
        float Height;
        float Line2;

        float Distance;//거리


        //Width = laserX - m_thisX;
        //Height = laserX - m_thisY;
        //Line2 = Width * Width + Height * Height;


        //Distance = Mathf.Sqrt(Line2);//빗변

        Width = Mathf.Abs(laserX - m_thisX);
        Height = Mathf.Abs(laserX - m_thisY);
        float Radian;
        Radian = Mathf.Atan2(Height, Width);
        float Angle;
        Angle = Radian * 180 * Mathf.PI;

        //int nCount=0;
        //if (nCount >= 0)
        //{
        //    Debug.Log(Angle);
        //    Debug.Log("반대편 앵글:" + (Angle + 180));
        //}   
        //nCount += 1;

    }
}