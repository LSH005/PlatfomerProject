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

    private int VoiceTick = 10;
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
                subtitle.text = "큐보리는 가장 잘 생긴 교수님인";
                ImageSource.sprite = Image[0];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[0]);
                break;

            case 75:
                subtitle.text = "♥♥송재광♥♥";
                BGMAudioSource.Pause();
                break;

            case 85:
                subtitle.text = "아니;;";
                ImageSource.sprite = Image[1];
                break;

            case 105:
                subtitle.text = "유★재★원 교수님의 중간평가를 마쳤습니다.";
                ImageSource.sprite = Image[0];
                BGMAudioSource.UnPause();
                break;

            case 160:
                subtitle.text = "큐보리는 그 대가로,";
                ImageSource.sprite = Image[1];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[1]);
                break;

            case 190:
                subtitle.text = "우유를 얻었습니다.";
                ImageSource.sprite = Image[2];
                break;

            case 250:
                subtitle.text = "...";
                BGMAudioSource.Stop();
                break;

            case 300:
                subtitle.text = "입이 없는데";
                VoiceClipAudioSource.PlayOneShot(VoiceClip[2]);
                break;

            case 323:
                subtitle.text += " 우예 마시노????";
                break;

            case 340:
                VoiceClipAudioSource.PlayOneShot(VoiceClip[3]);
                subtitle.text = "";
                ImageSource.sprite = Image[3];
                break;

            case 350:
                VoiceClipAudioSource.PlayOneShot(VoiceClip[4]);
                ImageSource.sprite = Image[4];
                break;

            case 375:
                Application.Quit();

                #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
                #endif
                break;
        }
    }
}
