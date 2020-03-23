using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NodeManager : MonoBehaviour
{
    bool GameEnd = false;

    [HideInInspector]
    public static int AllNodeCount = 0;//노드들의 총 갯수를 확인하는 카운터용
    // Start is called before the first frame update
    public GameObject result;

    private void Awake()
    {
        AllNodeCount = 0;//초기화
    }

    void Start()
    {
        //result.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (AllNodeCount <= 0 && GameEnd == false)
        {
            
            GameEnd = true;
            //결과창 출력
            result.SetActive(true);
            GameObject.Find("FXManager").GetComponent<FXManager>().SoundManager_F("StageClear");
            if(SceneManager.GetActiveScene().name == "1. Hello World")
                PlayerPrefs.SetInt("StageProcess1", 1);
            if (SceneManager.GetActiveScene().name == "2. Use Your Opportunity")
                PlayerPrefs.SetInt("StageProcess1", 2);
            if (SceneManager.GetActiveScene().name == "3. Two Times")
                PlayerPrefs.SetInt("StageProcess1", 3);
            if (SceneManager.GetActiveScene().name == "4. Reflect")
                PlayerPrefs.SetInt("StageProcess1", 4);

            PlayerPrefs.Save();
            //Instantiate(result, new Vector3(0, 0, 0), Quaternion.identity); 

        }
    }
}
