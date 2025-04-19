using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutScene_End : MonoBehaviour
{
    [Header("보이스클립 오디오 소스")]
    public AudioSource VoiceClipAudioSource;
    public AudioClip[] VoiceClip;

    [Header("BGM 오디오 소스")]
    public AudioSource BGMAudioSource;
    public AudioClip BGM;

    [Header("이미지 소스")]

    public Image ImageSource;
    public Sprite[] Image;

    [Header("자막 텍스트")]
    public GameObject SubtitleText;

    private TextMeshProUGUI subtitle;

    private int VoiceTick = 0;

    private float RealTime = 0f;


    void Start()
    {
        subtitle = SubtitleText.GetComponent<TextMeshProUGUI>();
        subtitle.text = "";

        BGMAudioSource.clip = BGM;
        BGMAudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        RealTime += Time.deltaTime;
        if (0.05f <= RealTime)
        {
            VoiceTick++;
            RealTime = 0f;

            CutSceneAudioAct();
        }
    }

    public void CutSceneAudioAct()
    {
        switch (VoiceTick)
        {
            case 30:
                Camera.main.backgroundColor = Color.white;

                subtitle.text = "큐보리는 자기가 왜 격어야 하는지 모를 중간평가를 마쳤습니다.";
                ImageSource.sprite = Image[0];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[0]);
                break;

            case 90:
                subtitle.text = "큐보리는 그 대가로";
                VoiceClipAudioSource.PlayOneShot(VoiceClip[1]);
                break;

            case 120:
                subtitle.text = "우유를 얻었습니다.";
                ImageSource.sprite = Image[1];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[2]);
                break;
        }
    }
}
