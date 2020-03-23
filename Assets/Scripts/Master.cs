using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using eageramoeba.Lasers;

public class Master : MonoBehaviour
{

    public bool isReceive;//레이저를 받는 중인지 확인하기 위함
    public GameObject receiveFrom;//레이저를 쏘는 옵젝

    protected void Start()
    {
    }
    protected void Update()
    {
        if(receiveFrom != null)
        {
            var hasLaser = receiveFrom.GetComponentInChildren<LazerObject>();
            isReceive = hasLaser != null && hasLaser.hit == this.gameObject;
            receiveFrom = isReceive ? receiveFrom : null;
        }

    }

}
