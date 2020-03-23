using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float TimeCount;
    public GameObject ResultWindow;

    [HideInInspector]
    public static string TimeText;
    float TimeFloat = 0;
    int TimeInt = 0;

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if(ResultWindow.active == false)
        TimeCount += Time.deltaTime;

        TimeFloat = Mathf.Ceil(TimeCount);

        if (TimeInt + 1 <= TimeFloat / 60)//분 추가
            TimeInt++;

        if (TimeFloat >= 60)
        {
            if (TimeFloat% 60 < 10)
                TimeText = TimeInt + ":0" + TimeFloat % 60;
            else
                TimeText = TimeInt / 60 + ":" + TimeFloat % 60;
        }

        else
        {
            if (TimeFloat < 10)
                TimeText = 0 + ":0" + TimeFloat % 60;
            else
                TimeText = 0 + ":" + TimeFloat % 60;
        }

        TimeText.ToString();


        //Debug.Log(TimeText);

        
    }
}
