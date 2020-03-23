using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FXScroll : MonoBehaviour
{
    float FXProgress = 0;

    void Start()
    {
        FXProgress = PlayerPrefs.GetFloat("FXProgress", default);
        gameObject.GetComponent<Slider>().value = FXProgress;
    }

    void Update()
    {

    }

    public void FXSave()
    {
        FXProgress = gameObject.GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("FXProgress", FXProgress);
        PlayerPrefs.Save();
        //Debug.Log("FX Save");
    }
}
