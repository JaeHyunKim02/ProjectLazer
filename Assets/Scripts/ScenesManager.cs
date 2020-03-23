using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CHScene_JH : MonoBehaviour
{
    public string NowScene;
    public string Next;
    public void ChangesSceneStageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }
    public void ChagnesSceneTItle()
    {
        SceneManager.LoadScene("Title");
    }
}
