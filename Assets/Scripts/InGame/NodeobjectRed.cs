using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeobjectRed : NodeObject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
        if (isReceive)
        {
            var master = receiveFrom.GetComponent<Master>();
            // 링크드 리스트 타고가는건 알아서...
            if (master is LazerObject)
            {
                LazerObject lazer = (LazerObject)master;
                //lazer.color
            }
        }
    }
}
