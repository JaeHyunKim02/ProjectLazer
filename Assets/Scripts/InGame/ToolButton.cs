using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class ToolButton : MonoBehaviour
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

    public void OnTool()
    {
        if (isOpen)
        {
            var sequence = DOTween.Sequence();
            foreach (var item in buttons)
            {
                sequence.Join(item.transform.DOMoveX(150, 0.2f, true));
            }
            sequence.OnComplete(() =>
            {
                buttons[0].SetActive(false);
                buttons[1].SetActive(false);
                buttons[2].SetActive(false);
                buttons[3].SetActive(false);
            }).Play();
            isOpen = false;
            //Debug.Log("DoTweet Play");
        }
        else if (!isOpen)
        {
            var sequence = DOTween.Sequence();
            buttons[0].SetActive(true);
            buttons[1].SetActive(true);
            buttons[2].SetActive(true);
            buttons[3].SetActive(true);
            sequence.Join(buttons[0].transform.DOMoveX(150, 0.2f, true));
            sequence.Join(buttons[1].transform.DOMoveX(350, 0.2f, true));
            sequence.Join(buttons[2].transform.DOMoveX(550, 0.2f, true));
            sequence.Join(buttons[3].transform.DOMoveX(750, 0.2f, true));
            sequence.Join(buttons[4].transform.DOMoveX(950, 0.2f, true));
            
            sequence.Play();
            isOpen = true;
            Debug.Log("isOpen " + isOpen);
        }
    }
}
