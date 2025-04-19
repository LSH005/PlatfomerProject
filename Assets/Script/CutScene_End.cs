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

                subtitle.text = "ť������ �ڱⰡ �� �ݾ�� �ϴ��� �� �߰��򰡸� ���ƽ��ϴ�.";
                ImageSource.sprite = Image[0];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[0]);
                break;

            case 90:
                subtitle.text = "ť������ �� �밡��";
                VoiceClipAudioSource.PlayOneShot(VoiceClip[1]);
                break;

            case 120:
                subtitle.text = "������ ������ϴ�.";
                ImageSource.sprite = Image[1];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[2]);
                break;
        }
    }
}
