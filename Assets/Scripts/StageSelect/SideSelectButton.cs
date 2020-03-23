using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSelectButton : MonoBehaviour
{
    public static int NowWorld;
    void Start()
    {
        NowWorld = 1;
    }


    void Update()
    {
        
    }

    public void LeftButton()
    {
        GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("Touch");
        if (NowWorld >= 2)
            NowWorld--;
        //Debug.Log("Now World: " + NowWorld);
    }

    public void RightButton()
    {
        GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("Touch");
        if (NowWorld <= 1)
            NowWorld++;
        //Debug.Log("Now World: " + NowWorld);
    }
}
