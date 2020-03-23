using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoInGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickStage()
    {
        if (gameObject.name == "StageButton1")
            SceneManager.LoadScene("1. Hello World");
        if (gameObject.name == "StageButton2")
            SceneManager.LoadScene("2. Use Your Opportunity");
        if (gameObject.name == "StageButton3")
            SceneManager.LoadScene("3. Two Times");
        if (gameObject.name == "StageButton4")
            SceneManager.LoadScene("4. Reflect");


    }
}
