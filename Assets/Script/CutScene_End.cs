using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutScene_End : MonoBehaviour
{
    [Header("���̽�Ŭ�� ����� �ҽ�")]
    public AudioSource VoiceClipAudioSource;
    public AudioClip[] VoiceClip;

    [Header("BGM ����� �ҽ�")]
    public AudioSource BGMAudioSource;
    public AudioClip BGM;

    [Header("�̹��� �ҽ�")]

    public Image ImageSource;
    public Sprite[] Image;

    [Header("�ڸ� �ؽ�Ʈ")]
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
                subtitle.text = "ť������ ���� �� ���� ��������";
                ImageSource.sprite = Image[0];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[0]);
                break;

            case 75:
                subtitle.text = "�������籤����";
                BGMAudioSource.Pause();
                break;

            case 85:
                subtitle.text = "�ƴ�;;";
                ImageSource.sprite = Image[1];
                break;

            case 105:
                subtitle.text = "������ڿ� �������� �߰��򰡸� ���ƽ��ϴ�.";
                ImageSource.sprite = Image[0];
                BGMAudioSource.UnPause();
                break;

            case 160:
                subtitle.text = "ť������ �� �밡��,";
                ImageSource.sprite = Image[1];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[1]);
                break;

            case 190:
                subtitle.text = "������ ������ϴ�.";
                ImageSource.sprite = Image[2];
                break;

            case 250:
                subtitle.text = "...";
                BGMAudioSource.Stop();
                break;

            case 300:
                subtitle.text = "���� ���µ�";
                VoiceClipAudioSource.PlayOneShot(VoiceClip[2]);
                break;

            case 323:
                subtitle.text += " �쿹 ���ó�????";
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
