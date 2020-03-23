using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{

    public void ChangesSceneStageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void ChagnesSceneTItle()
    {
        SceneManager.LoadScene("Title");
    }
}
