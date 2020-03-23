using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_DownButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRestart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void OnExit()
    {
        SceneManager.LoadScene("Title");
    }
}
