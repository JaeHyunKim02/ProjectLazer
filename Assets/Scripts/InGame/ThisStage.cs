using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThisStage : MonoBehaviour
{
    string ThisStageName;

    void Awake()
    {
        ThisStageName = SceneManager.GetActiveScene().name;
        Debug.Log(ThisStageName);
        gameObject.GetComponent<Text>().text = ThisStageName;
    }
}
