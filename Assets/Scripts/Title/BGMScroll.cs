using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMScroll : MonoBehaviour
{
    float BGMProgress = 0;

    void Start()
    {
        BGMProgress = PlayerPrefs.GetFloat("BGMProgress", default);
        gameObject.GetComponent<Slider>().value = BGMProgress;
    }

    void Update()
    {
        
    }

    public void BGMSave()
    {
        BGMProgress = gameObject.GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("BGMProgress", BGMProgress);
        PlayerPrefs.Save();
        //Debug.Log("BGM Save");
    }
}
