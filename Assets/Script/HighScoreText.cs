using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreText : MonoBehaviour
{
    public TextMeshProUGUI Lv_1;
    public TextMeshProUGUI Lv_2;
    public TextMeshProUGUI Lv_3;
    public TextMeshProUGUI Lv_4;
    public TextMeshProUGUI Lv_5;

    // Start is called before the first frame update
    void Start()
    {
        Lv_1.text = "LV1 : [" + (HighScore.Load(1) / 100f).ToString("F2") + "] 段";
        Lv_2.text = "LV2 : [" + (HighScore.Load(2) / 100f).ToString("F2") + "] 段";
        Lv_3.text = "LV3 : [" + (HighScore.Load(3) / 100f).ToString("F2") + "] 段";
        Lv_4.text = "LV4 : [" + (HighScore.Load(4) / 100f).ToString("F2") + "] 段";
        Lv_5.text = "LV5 : [" + (HighScore.Load(5) / 100f).ToString("F2") + "] 段";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
