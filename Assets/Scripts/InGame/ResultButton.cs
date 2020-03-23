using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBack()
    {
        SceneManager.LoadScene("Title");
        GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("Touch");
    }

    public void OnSelect()
    {
        SceneManager.LoadScene("StageSelect");
        GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("Touch");
    }

    public void OnNext()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1));
        GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("Touch");
    }
}
