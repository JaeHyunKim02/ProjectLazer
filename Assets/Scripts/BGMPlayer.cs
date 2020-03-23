using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMPlayer : MonoBehaviour
{
    GameObject BGMManager;
   

    void Start()
    {
        //BGMManager = GameObject.Find("BGMManager");

        //if(SceneManager.GetActiveScene().name == "Title" || SceneManager.GetActiveScene().name == "StageSelect")
        //    BGMManager.GetComponent<BGMManager>().SoundManager("TitleBGM");
        //if (SceneManager.GetActiveScene().name == "InGame")
        //    BGMManager.GetComponent<BGMManager>().SoundManager("InGameBGM");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
