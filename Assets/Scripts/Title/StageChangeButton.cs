using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageChangeButton : MonoBehaviour
{
    public string NextStageName;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ClickNextScene()
    {
        //DataManager.SetInt(6);
        GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("Touch");
        //Debug.Log("FadeObject Wake Up");

        //fade.GetComponent<FadeOpacity>().StartCoroutine(fade.GetComponent<FadeOpacity>().FadeOutting(NextStageName));

    }
}
