using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutScene_ED : MonoBehaviour
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

    [Header("UI �ؽ�Ʈ")]
    public GameObject InfoText;


    private TextMeshProUGUI subtitle;
    private TextMeshProUGUI infoText;

    private int VoiceTick = 10;
    private int ImageNumber = 3;

    private float RealTime = 0f;
    private float ThatVoiceImageResistance = 0f;
    private float RandomLimit = 0.25f;
    private float SkipScene = 0f;

    private bool ThatVoice = false;

    void Start()
    {
        subtitle = SubtitleText.GetComponent<TextMeshProUGUI>();
        infoText = InfoText.GetComponent<TextMeshProUGUI>();
        subtitle.text = "";
        Camera.main.backgroundColor = Color.black;

        BGMAudioSource.clip = BGM;
        BGMAudioSource.Play();
    }

    void Update()
    {
        RealTime += Time.deltaTime;
        if (0.05f <= RealTime)
        {
            VoiceTick++;
            RealTime = 0f;

            CutSceneAudioAct();
        }
        if (ThatVoice)
        {
            ThatVoiceImage();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            SkipScene += Time.deltaTime;
            infoText.text = "��ŵ ��!";
            if (SkipScene >= 1.0f)
            {
                SceneManager.LoadScene("Lv_1");
            }
        }
        else
        {
            SkipScene = 0f;
            infoText.text = "�����̽� �ٸ� ��� ������ ��ŵ";
        }
    }


    public void CutSceneAudioAct()
    {
        switch (VoiceTick)
        {
            case 30:
                Camera.main.backgroundColor = Color.white;

                subtitle.text = "ť������ �Ͼ� �濡�� ��� �־����ϴ�.";
                ImageSource.sprite = Image[0];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[0]);
                break;

            case 90:
                subtitle.text = "ť������ ���� �����߽��ϴ�.";
                ImageSource.sprite = Image[1];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[1]);
                break;

            case 140:
                subtitle.text = "�ƹ� �ϵ� �������ϴ�.";
                ImageSource.sprite = Image[2];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[2]);
                break;

            case 200:
                subtitle.text = "��� ��.";
                VoiceClipAudioSource.PlayOneShot(VoiceClip[4]);
                break;

            case 220:
                subtitle.text = subtitle.text + " ť������ ��Ҹ��� ������ϴ�.";
                ImageSource.sprite = Image[3];
                break;

            case 265:
                subtitle.text = "�� �ź��� ��Ҹ��� �ϴÿ��� ����Խ��ϴ�.";
                ImageSource.sprite = Image[8];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[5]);
                break;

            case 330:
                StartCoroutine(VoiceClip6_Subtitle());
                BGMAudioSource.Pause();
                break;

            case 1130:
                subtitle.text = "�ϴÿ��� ����� ��Ҹ��� ť�������� �÷��� ���Ƚ��ϴ�.";
                ImageSource.sprite = Image[9];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[7]);
                BGMAudioSource.UnPause();
                break;

            case 1212:
                subtitle.text = "�߰���� ��ü������� ����� ȯ����";
                ImageSource.sprite = Image[10];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[8]);
                break;

            case 1275:
                subtitle.text = "������ ������� ���̿����ϴ�.";
                break;

            case 1322:
                subtitle.text = "�׷��� ť������ 25�� ����";
                VoiceClipAudioSource.PlayOneShot(VoiceClip[9]);
                break;

            case 1377:
                subtitle.text = "�ڽ���";
                break;

            case 1387:
                subtitle.text += " �����α���";
                BGMAudioSource.Stop();
                ImageSource.sprite = Image[11];
                break;

            case 1404:
                subtitle.text += " ���������߽��ϴ�.";
                break;

            case 1414:
                subtitle.text = "";
                ImageSource.sprite = Image[12];
                break;

            case 1422:
                subtitle.text = "";
                ImageSource.sprite = Image[13];
                Camera.main.backgroundColor = Color.black;
                break;

            case 1470:
                SceneManager.LoadScene("Lv_1");
                break;
        }
    }
    IEnumerator VoiceClip6_Subtitle()
    {
        VoiceClipAudioSource.PlayOneShot(VoiceClip[6]);
        ThatVoice = true;
        subtitle.text = "�� �����е� �ݰ����ϴ�!";
        yield return Sleep(1.75);
        subtitle.text = "�����е��� �ߡڻ��ڱ� ������";
        yield return Sleep(1.75);
        subtitle.text = "�ڡڡ�Za�ڡڡ�";
        yield return Sleep(0.25);
        subtitle.text = "������ڿ� �������Դϴ�.";
        yield return Sleep(2);
        subtitle.text = "�߰���縦 �����ϴµ� �����е�";
        yield return Sleep(2.4);
        subtitle.text = "��@���� �ϳ��� ���Կ�";
        yield return Sleep(1.0);
        subtitle.text = "����;; ��������������";
        yield return Sleep(1.0);
        subtitle.text = "�������е� �÷����� 2D ����";
        yield return Sleep(2.0);
        subtitle.text = "�� �ϳ��� ����������!";
        yield return Sleep(1.1);
        subtitle.text = "��.��.��";
        yield return Sleep(1.0);
        subtitle.text = "�� �����̳��ƴ��� �� ��????";
        yield return Sleep(2.25);
        subtitle.text = "�׷��ߴ�ϴ�~";
        yield return Sleep(1);
        subtitle.text = "�׸��� �� ������ �� �i�ƿ;� �ؿ�!";
        yield return Sleep(1.75);
        subtitle.text = "�Ƹ��ڿ�!!";
        yield return Sleep(0.4);
        subtitle.text = "(�ڼ�¦)";
        yield return Sleep(0.25);
        subtitle.text = "����! ��@�� �־���ؿ�!! ��@@@��";
        yield return Sleep(2.25);
        subtitle.text = "��";
        yield return Sleep(0.2);
        subtitle.text += " ���� ������";
        yield return Sleep(0.4);
        subtitle.text += " �з��𸶳�";
        yield return Sleep(0.7);
        subtitle.text += " ���� ������ �־���ϴµ�;;";
        yield return Sleep(1);
        subtitle.text = "�����е�";
        yield return Sleep(1);
        subtitle.text = "��~ ��";
        yield return Sleep(0.05);
        subtitle.text += " �� �����";
        yield return Sleep(0.05);
        subtitle.text += " ��...";
        yield return Sleep(1.5);
        subtitle.text = "(�޸� ����)";
        yield return Sleep(0.7);
        subtitle.text = "�� ����� �� �ְ���???";
        yield return Sleep(1.7);
        subtitle.text = "�Ƹ´��̰�";
        yield return Sleep(0.75);
        subtitle.text = "��~~ �̰� �´�!";
        yield return Sleep(0.6);
        subtitle.text = "�̰� ������Դϴ�";
        yield return Sleep(0.9);
        subtitle.text += " �����";
        yield return Sleep(1.3);
        subtitle.text = "��������";
        yield return Sleep(0.9);
        subtitle.text += " ����";
        yield return Sleep(0.4);
        subtitle.text += " �ס��̡ڸ� �˴ϴ�!!";
        yield return Sleep(1.75);
        subtitle.text = "���� ������ ����մϴ� ����";
        for (int i = 0; i < 10; i++)
        {
            yield return Sleep(0.02);
            subtitle.text = "�̾�!!!!!!!!!!!!!!!!!!";
            yield return Sleep(0.02);
            subtitle.text = "";
        }
        ThatVoice = false;
        ImageSource.sprite = Image[8];
    }

    private void ThatVoiceImage()
    {
        ThatVoiceImageResistance += Time.deltaTime;

        if (ThatVoiceImageResistance >= RandomLimit)
        {
            ThatVoiceImageResistance = 0;
            RandomLimit = UnityEngine.Random.Range(0.1f, 0.5f);

            ImageNumber++;
            if (ImageNumber == 8)
            {
                ImageNumber = 4;
            }

            ImageSource.sprite = Image[ImageNumber];
        }
    }

    IEnumerator Sleep(double SleepSeconds)
    {
        yield return new WaitForSeconds((float)SleepSeconds);
    }

}
