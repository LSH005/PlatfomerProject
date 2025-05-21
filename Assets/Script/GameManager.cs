using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button gameStartButton;

    void Start()
    {
        gameStartButton.onClick.AddListener(OnGameStartButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGameStartButtonClicked()
    {
        string playerName = inputField.text;
        if (string.IsNullOrEmpty(playerName))
        {
            Debug.Log("nah");
            return;
        }

        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();

        Debug.Log("플레이어 이름 저장 == " + playerName);
        SceneManager.LoadScene("Lv_1");
    }
}
