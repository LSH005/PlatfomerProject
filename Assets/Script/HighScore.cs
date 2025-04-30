using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    private const string KEY = "HighScore";
    public static float Load(int stage)
    {
        return PlayerPrefs.GetInt(KEY + "_" + stage, 999999999);
    }

    public static void TrySet(int stage, int newScore)
    {
        if (newScore >= Load(stage))
        {
            return;
        }

        PlayerPrefs.SetInt(KEY + "_" + stage, newScore);
        PlayerPrefs.Save();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
