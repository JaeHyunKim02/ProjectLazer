using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeObject : Master
{
   
    public bool NodeChecker =  false;//노드가 사용가능한지 확인
    bool DoOnce = false;//한번만

    public int test;

    //재현
    public Sprite NodeOn;
    public Sprite NodeOff;
    private SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        NodeManager.AllNodeCount += 1;// 현재 씬의 노드당 +1
        Debug.Log("노드상황 (아무 노드도 없을때 0): " + NodeManager.AllNodeCount);

        //재현
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = NodeOff;

    }

    private void Update()
    {
        base.Update();
        Debug.Log(DoOnce);
        if (isReceive && !DoOnce)//DoOnce도 true일때
        {
            Debug.Log("NodeOn!");
            NodeChecker = true;
            NodeManager.AllNodeCount -= 1;
            Debug.Log("노드상황: "+ NodeManager.AllNodeCount);
            DoOnce = true;//1회만 실행

            //재현
            spriteRenderer.sprite = NodeOn;
            GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("NodeOn");

        }
        else if(!isReceive && DoOnce)
        {
            NodeChecker = false;
            NodeManager.AllNodeCount += 1;
            Debug.Log("노드상황: " + NodeManager.AllNodeCount);
            DoOnce = false;

            //재현
            spriteRenderer.sprite = NodeOff;
            GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("NodeOff");
        }
        
    }
}
