using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CutScene_OP : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] VoiceClip;

    public int GameTick = 0;
    public float GameTickCooldown = 3.5f;

    public GameObject SubtitleText;

    private TextMeshProUGUI subtitle;

    void Start()
    {
        subtitle = SubtitleText.GetComponent<TextMeshProUGUI>();
        subtitle.text = "";
    }

    void Update()
    {
        GameTickCooldown -= Time.deltaTime;
        if (0f >= GameTickCooldown)
        {
            GameTick++;
            CutSceneAct();
        }
    }

    public void CutSceneAct()
    {
        switch (GameTick)
        {
            case 1:
                subtitle.text = "BrUh;;";
                audioSource.PlayOneShot(VoiceClip[0]);

                GameTickCooldown = 1.0f;
                break;
            case 2:

                break;
        }
    }
}
