using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    //public AudioClip TitleBGM;
    //public AudioClip SelectBGM;
    //public AudioClip InGameBGM;

    public AudioSource audio;

    void Awake()
    {
        audio.volume = PlayerPrefs.GetFloat("BGMProgress", default);
   
    }

    void Update()
    {
        audio.volume = PlayerPrefs.GetFloat("BGMProgress", default);
         
    }

    //public void SoundManager(string audioName)
    //{

    //    if (audioName == "TitleBGM")
    //    {
    //        audio.PlayOneShot(TitleBGM);
    //    }

    //    if (audioName == "SelectBGM")
    //    {
    //        audio.PlayOneShot(SelectBGM);
    //    }

    //    if (audioName == "InGameBGM")
    //    {
    //        audio.PlayOneShot(InGameBGM);
    //    }
    //}
}
