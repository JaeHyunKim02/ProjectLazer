using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizmTriangletest : LazerObject
{


    private float FL_rotateSpeed = -15.0f;
    private float yaw = 0.0f;
    private bool isDragged;

    public GameObject LaserR;
    public GameObject LaserG;
    public GameObject LaserB;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();

        LaserR.SetActive(false);
        LaserG.SetActive(false);
        LaserB.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();

        if (isReceive){
            LaserR.SetActive(true);
            LaserG.SetActive(true);
            LaserB.SetActive(true);

        }
        else
        {
            LaserR.SetActive(true);
            LaserG.SetActive(true);
            LaserB.SetActive(true);

        }

    }
}
