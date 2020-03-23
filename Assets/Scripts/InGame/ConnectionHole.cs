using eageramoeba.Lasers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;


public class ConnectionHole : Master//LazerObject
{

    public Sprite ConnectionHoleInLigthOn;
    public Sprite ConnectionHoleInLightOff;
    public Sprite ConnectionHoleOutLightOn;
    public Sprite ConnectionholeOutLightOff;
    public GameObject ConnectionHoleLaser;
    public SpriteRenderer spriteRendererIn;
    public SpriteRenderer spriteRendererOut;

    private float FL_rotateSpeed = -15.0f;
    private float yaw = 0.0f;
    private bool isDragged;


    public void Start()
    {
        //base.Start();
        //base.Start();
        //laser = ConnectionHoleLaser.GetComponent<laser>();
        //ConnectionHoleLaser.GetComponent<laser>().onM = false;
        //ConnectionHoleLaser.SetActive(false);
        ConnectionHoleLaser.SetActive(false);
        spriteRendererIn.sprite = ConnectionholeOutLightOff;
        spriteRendererOut.sprite = ConnectionHoleInLightOff;
        

    }
    public void Update()
    {
        base.Update();
        if (isReceive)
        {
            ConnectionHoleLaser.SetActive(true);
            spriteRendererIn.sprite = ConnectionHoleInLigthOn;
            spriteRendererOut.sprite = ConnectionHoleOutLightOn;
            var linkedLaser = ConnectionHoleLaser.GetComponent<laser>();

            while (linkedLaser.directChild != null)
            {
                linkedLaser = linkedLaser.directChild.GetComponentInChildren<laser>();
            }
            var hit = linkedLaser.hitGO;
            if (hit != null)
            {
                var hasMaster = hit.GetComponentInChildren<Master>();
                if (hasMaster != null)
                {
                    hasMaster.isReceive = true;
                    hasMaster.receiveFrom = this.transform.parent.gameObject;
                }
            }

            // ConnectionHoleLaser.GetComponent<laser>().onM = true;
            //if (!ConnectionHoleLaser.activeSelf)
            //{
            //   // Debug.Log("test");
            //    ConnectionHoleLaser.SetActive(true);
            //    var master = receiveFrom.GetComponent<Master>();
            //    // 링크드 리스트 타고가는건 알아서...
            //    if (master is LazerObject)
            //    {
            //        Debug.Log("test");
            //        LazerObject lazer = (LazerObject)master;
            //        var line = ConnectionHoleLaser.GetComponentInChildren<LineRenderer>();
            //        if(line != null)
            //            line.material = lazer.selectedColor;
            //    }
            //}


        }
        else    // if (isReceive == false && OnLaser == false)
        {
            //laser.onM = false;
            //if(ConnectionHoleLaser.activeSelf)
            //    ConnectionHoleLaser.SetActive(false);
            //ConnectionHoleLaser.GetComponent<laser>().onM = false;
            ConnectionHoleLaser.SetActive(false);
            spriteRendererIn.sprite = ConnectionHoleInLightOff;
            spriteRendererOut.sprite = ConnectionholeOutLightOff;
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
    }
}
