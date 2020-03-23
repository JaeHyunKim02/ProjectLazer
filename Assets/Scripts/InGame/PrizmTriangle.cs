using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizmTriangle : LazerObject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float laserX = linkedLaser.GetComponentInChildren<LineRenderer>().GetPosition(1).x;//x
        float laserY = linkedLaser.GetComponentInChildren<LineRenderer>().GetPosition(1).y;//y

        float m_thisX = receiveFrom.transform.position.x;//x2
        float m_thisY = receiveFrom.transform.position.y;//y2
        Debug.Log(laserX + "," + laserY + "," + m_thisX + "," + m_thisY);

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
