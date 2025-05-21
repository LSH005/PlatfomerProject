using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class RankPage : MonoBehaviour
{
    public GameObject TitleText;
    private TextMeshProUGUI titleText;

    [SerializeField] Transform contentRoot;
    [SerializeField] GameObject rowPrefab;

    StageResultList allData;

    public int stageNumber = 1;

    private void Awake()
    {
        titleText = TitleText.GetComponent<TextMeshProUGUI>();
        titleText.text = "LV 1 SCORE";
        allData = StageResultSaver.LoadRank();
        RefreshRankList();
    }

    void RefreshRankList()
    {
        foreach (Transform child in contentRoot)
        {
            Destroy(child.gameObject);
        }
        var sortedData = allData.results.Where(r=>r.stage==stageNumber).OrderBy(x=>x.score).ToList();

        for (int i = 0; i < sortedData.Count; i++)
        {
            GameObject row = Instantiate(rowPrefab, contentRoot);
            TMP_Text rankText = row.GetComponentInChildren<TMP_Text>();
            //rankText.text = $"# {i + 1} // {sortedData[i].playerName} : {(float)((sortedData[i].score)/100)} (sec)";
            rankText.text = $"[# {i + 1}]\n{sortedData[i].playerName}\n{(float)sortedData[i].score / 100f} (sec)";
        }
    }

    // Update is called once per frame¤À¤Ð
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            stageNumber++;

            if (stageNumber > 5)
            {
                stageNumber = 1;
            }
            titleText.text = $"LV {stageNumber} SCORE";
            RefreshRankList();
        }
    }
}
