using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXManager : MonoBehaviour
{
    public AudioClip NodeOn;
    public AudioClip NodeOff;
    public AudioClip Touch;
    public AudioClip WindowOff;
    public AudioClip StageClear;

    public AudioSource audio_F;

    void Start()
    {
    }

    void Update()
    {
       
        audio_F.volume = PlayerPrefs.GetFloat("FXProgress", default);
    }

    public void SoundManager_F(string audioName)
    {

        if (audioName == "NodeOn")
        {
            audio_F.PlayOneShot(NodeOn);
        }

        if (audioName == "NodeOff")
        {
            audio_F.PlayOneShot(NodeOff);
        }

        if (audioName == "Touch")
        {
            audio_F.PlayOneShot(Touch);
        }

        if (audioName == "WindowOff")
        {
            audio_F.PlayOneShot(WindowOff);
        }

        if (audioName == "StageClear")
        {
            audio_F.PlayOneShot(StageClear);
        }
    }
}
