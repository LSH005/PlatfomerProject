using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelObject : MonoBehaviour
{
    [Header("다음 레벨 신 이름")]
    public string NextLevel;

    public void MoveToNextLevel()
    {
        SceneManager.LoadScene(NextLevel);
    }


}
