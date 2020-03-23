using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class PauseButton : MonoBehaviour
{
    public GameObject[] buttons;
    bool isOpen;

    void Start()
    {
        isOpen = false;
    }

    void Update()
    {
    }

    public void OnPause()
    {
        if (isOpen)
        {
            var sequence = DOTween.Sequence();
            foreach (var item in buttons)
            {
                sequence.Join(item.transform.DOMoveY(1800, 0.2f, true));      
            }
            sequence.OnComplete(()=>
            {
                buttons[0].SetActive(false);
                buttons[1].SetActive(false);
                buttons[2].SetActive(false);
            }).Play();
            GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("Touch");
            isOpen = false;
            //Debug.Log("DoTweet Play");
        }
        else if (!isOpen)
        {
            var sequence = DOTween.Sequence();
            buttons[0].SetActive(true);
            buttons[1].SetActive(true);
            buttons[2].SetActive(true);
            sequence.Join(buttons[0].transform.DOMoveY(1650, 0.2f, true));
            sequence.Join(buttons[1].transform.DOMoveY(1500, 0.2f, true));
            sequence.Join(buttons[2].transform.DOMoveY(1350, 0.2f, true));
            sequence.Play();
            GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("Touch");
            isOpen = true;
            //Debug.Log("isOpen " + isOpen);
        }
    }
}
