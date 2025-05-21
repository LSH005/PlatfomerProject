using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using JetBrains.Annotations;
using System.IO;

[Serializable]
public class StageResult
{
    public string playerName;
    public int stage;
    public int score;
}
[Serializable]

public class StageResultList
{
    public List<StageResult> results=new List<StageResult>();
}

public static class StageResultSaver
{
    private const string FILE = "stage_result.json";
    private const string PLAYER_NAME = "PlayerName";
    private static string filePath= Path.Combine(Application.persistentDataPath, FILE);

    public static void SaveStage(int stage, int score)
    {
        StageResultList list = LoadInternal();
        string playerName = PlayerPrefs.GetString(PLAYER_NAME, "");
        StageResult entry = new StageResult()
        {
            playerName=playerName,
            stage=stage,
            score=score
        };
        list.results.Add(entry);
        string Json = JsonUtility.ToJson(list,true);
        File.WriteAllText(filePath, Json);
    }

    private static StageResultList LoadInternal()
    {
        if (!File.Exists(filePath)) return new StageResultList();

        string Json = File.ReadAllText(filePath);
        StageResultList list = JsonUtility.FromJson<StageResultList>(Json);
        if (list==null) return new StageResultList();
        else return list;
    }

    public static StageResultList LoadRank()
    {
        return LoadInternal();
    }
}
