using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    void Start()
    {
        //int a = 0;
        PlayerPrefs.GetInt("DataInt", default);

        if (PlayerPrefs.HasKey("DataInt") == true)
        {
            //a = PlayerPrefs.GetInt("DataInt");
            //Debug.Log(a);
        }
    }

    void Update()
    {
        
    }

    public static void SetInt(int intdata)
    {
        PlayerPrefs.SetInt("DataInt", intdata);
        PlayerPrefs.Save();
    }
    public static void SetFloat(float floatdata)
    {
        PlayerPrefs.SetFloat("DataFloat", floatdata);
        PlayerPrefs.Save();
    }
    public static void SetString(string strdata)
    {
        PlayerPrefs.SetString("DataString",strdata);
        PlayerPrefs.Save();
    }
}
