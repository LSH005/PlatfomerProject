using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelObject : MonoBehaviour
{
    [Header("���� ���� �� �̸�")]
    public string NextLevel;
    /*
    [Header("�� ���� ��������Ʈ")]
    public SpriteRenderer targetRenderer;  // SpriteRenderer�� ����
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
