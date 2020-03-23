using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageProgress : MonoBehaviour
{
    int NowStageScreen = 1;

    void Awake()
    {
        int stage1 = 0;
        int stage2 = 0;
        //PlayerPrefs.SetInt("StageProcess1", 1);
        //PlayerPrefs.SetInt("StageProcess2", 0);

        stage1 = PlayerPrefs.GetInt("StageProcess1", default);
        stage2 = PlayerPrefs.GetInt("StageProcess2", default);

        for (int i = 0; i <= stage1; i++)
        {
            if (null != GameObject.Find("Canvas").transform.Find("Planet1").transform.Find("StageScroll").transform.Find("Content").transform.Find("S" + (i + 1)))
            {
                GameObject.Find("Canvas").transform.Find("Planet1").transform.Find("StageScroll").transform.Find("Content").transform.Find("S" + (i + 1)).transform.Find("L_StageButton" + (i +1)).gameObject.SetActive(false);
                GameObject.Find("Canvas").transform.Find("Planet1").transform.Find("StageScroll").transform.Find("Content").transform.Find("S" + (i + 1)).transform.Find("StageButton" + (i + 1)).gameObject.SetActive(true);
                if (i != stage1)
                    GameObject.Find("Canvas").transform.Find("Planet1").transform.Find("StageScroll").transform.Find("Content").transform.Find("S" + (i + 1)).transform.Find("StageButton" + (i + 1)).transform.Find("StarToggle").gameObject.GetComponent<Toggle>().isOn = true;
            }
        }
        for (int i = 0; i <= stage2; i++)
        {
            if (null != GameObject.Find("Canvas").transform.Find("Planet2").transform.Find("StageScroll").transform.Find("Content").transform.Find("S" + (i + 1)))
            {
                GameObject.Find("Canvas").transform.Find("Planet2").transform.Find("StageScroll").transform.Find("Content").transform.Find("S" + (i + 1)).transform.Find("L_StageButton" + (i + 1)).gameObject.SetActive(false);
                GameObject.Find("Canvas").transform.Find("Planet2").transform.Find("StageScroll").transform.Find("Content").transform.Find("S" + (i + 1)).transform.Find("StageButton" + (i + 1)).gameObject.SetActive(true);
                if (i != stage2)
                    GameObject.Find("Canvas").transform.Find("Planet2").transform.Find("StageScroll").transform.Find("Content").transform.Find("S" + (i + 1)).transform.Find("StageButton" + (i + 1)).transform.Find("StarToggle").gameObject.GetComponent<Toggle>().isOn = true;
            }

        }
    }

    void Update()
    {

        if (NowStageScreen != SideSelectButton.NowWorld)
        {
            GameObject.Find("Canvas").transform.Find("Planet" + NowStageScreen).gameObject.SetActive(false);
            NowStageScreen = SideSelectButton.NowWorld;
            GameObject.Find("Canvas").transform.Find("Planet" + NowStageScreen).gameObject.SetActive(true);
        }
    }
}
