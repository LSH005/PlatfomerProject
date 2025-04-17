using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CutScene_OP : MonoBehaviour
{
    [Header("����� �ҽ�")]
    public AudioSource audioSource;
    public AudioClip[] VoiceClip;

    [Header("�̹��� �ҽ�")]

    public Image ImageSource;
    public Sprite[] Image;

    [Header("�ڸ� �ؽ�Ʈ")]
    public GameObject SubtitleText;


    private TextMeshProUGUI subtitle;

    private int VoiceTick = 0;
    private bool MoveImage=false;
    private float RealTime = 0f;

    void Start()
    {
        subtitle = SubtitleText.GetComponent<TextMeshProUGUI>();
        subtitle.text = "";
        Camera.main.backgroundColor = Color.black;

        VoiceTick = 10;
    }

    void Update()
    {
        RealTime+= Time.deltaTime;
        if (0.05f <= RealTime)
        {
            VoiceTick++;
            RealTime = 0f;

            CutSceneAudioAct();

            if (MoveImage)
            {
                CutSceneImageAct();
            }
        }
    }

    public void CutSceneAudioAct()
    {
        switch (VoiceTick)
        {
            case 30:
                Camera.main.backgroundColor = Color.white;

                subtitle.text = "ť������ �Ͼ� �濡�� ��� �־����ϴ�.";
                audioSource.PlayOneShot(VoiceClip[0]);
                break;

            case 90:
                subtitle.text = "ť������ ���� �����߽��ϴ�.";
                audioSource.PlayOneShot(VoiceClip[1]);
                break;

            case 150:
                subtitle.text = "�ƹ� �ϵ� �������ϴ�.";
                audioSource.PlayOneShot(VoiceClip[2]);
                break;

            case 200:
                subtitle.text = "��� ��.";
                audioSource.PlayOneShot(VoiceClip[4]);
                break;

            case 220:
                subtitle.text = subtitle.text+" ť������ ��Ҹ��� ������ϴ�.";
                break;

            case 265:
                subtitle.text = "�� �ź��� ��Ҹ��� �ϴÿ��� ����Խ��ϴ�.";
                audioSource.PlayOneShot(VoiceClip[5]);
                break;

            case 330:
                StartCoroutine(VoiceClip6_Subtitle());
                break;

            case 1130:
                subtitle.text = "�ϴÿ��� ����� ��Ҹ��� ť�������� �÷��� ���Ƚ��ϴ�.";
                audioSource.PlayOneShot(VoiceClip[7]);
                break;

            case 1212:
                subtitle.text = "�߰���� ��ü������� ����� ȯ����";
                audioSource.PlayOneShot(VoiceClip[8]);
                break;

            case 1275:
                subtitle.text = "������ ������� ���̿����ϴ�.";
                break;

            case 1322:
                subtitle.text = "�׷��� ť������ 25�� ����";
                audioSource.PlayOneShot(VoiceClip[9]);
                break;

            case 1377:
                subtitle.text = "�ڽ���";
                break;

            case 1387:
                subtitle.text += " �����α���";
                break;

            case 1404:
                subtitle.text += " ���������߽��ϴ�. ��������";
                break;

            case 1462:
                subtitle.text = "...";
                break;
        }
    }
    IEnumerator VoiceClip6_Subtitle()
    {
        audioSource.PlayOneShot(VoiceClip[6]);
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
        subtitle.text += " ��@123�̸� �˴ϴ�!!";
        yield return Sleep(1.75);
        subtitle.text = "�̾�!@!!!!!!";
        for (int i = 0; i < 10; i++)
        {
            yield return Sleep(0.02);
            subtitle.text = "����������������";
            yield return Sleep(0.02);
            subtitle.text = "";
        }

    }

    public void CutSceneImageAct()
    {
        
    }

    IEnumerator Sleep(double SleepSeconds)
    {
        yield return new WaitForSeconds((float)SleepSeconds);
    }

}
