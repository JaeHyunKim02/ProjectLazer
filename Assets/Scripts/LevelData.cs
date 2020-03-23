using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class LevelData : ScriptableObject
{
    public GameObject MapData;
#if UNITY_EDITOR
    [MenuItem("Tools/레벨 저장하기")]
    public static void SaveAsset()
    {
        LevelData data = new LevelData();
        Master[] targetMapObjects = GameObject.FindObjectsOfType<Master>();
        //data.MapData = new LevelData(targetMapObjects);
        AssetDatabase.CreateAsset(data,"Assets/Levels/new.asset");
    }
#endif

}
