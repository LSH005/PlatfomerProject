using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelObject : MonoBehaviour
{
    [Header("다음 레벨 신 이름")]
    public string NextLevel;
    /*
    [Header("끝 지점 스프라이트")]
    public SpriteRenderer targetRenderer;  // SpriteRenderer를 연결
    public Sprite newSprite;

    private float RealTime = 0f;
    private int ShapeTick = 0;

    void Update()
    {
        RealTime += Time.deltaTime;
        if (0.05f <= RealTime)
        {
            ShapeTick++;
            RealTime = 0f;

            
        }
    }
    */
    public void MoveToNextLevel()
    {
        SceneManager.LoadScene(NextLevel);
    }


}
