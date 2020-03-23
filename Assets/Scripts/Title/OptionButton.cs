using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButton : MonoBehaviour
{
    public GameObject OptionWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickOption()
    {
        OptionWindow.SetActive(true);
        GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("Touch");
    }

    public void CloseOption()
    {
        OptionWindow.SetActive(false);
        GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("WindowOff");
    }
}
