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

    [Header("�ڸ� �ؽ�Ʈ")]
    public GameObject SubtitleText;


    private TextMeshProUGUI subtitle;

    private int GameTick = 0;
    private float RealTime = 0f;

    void Start()
    {
        subtitle = SubtitleText.GetComponent<TextMeshProUGUI>();
        subtitle.text = "";
    }

    void Update()
    {
        RealTime+= Time.deltaTime;
        if (0.05f <= RealTime)
        {
            GameTick++;
            RealTime = 0f;
            CutSceneAct();
        }
    }

    public void CutSceneAct()
    {
        switch (GameTick)
        {
            case 1:
                subtitle.text = "ť������ �Ͼ� �濡�� ��� �־����ϴ�.";
                audioSource.PlayOneShot(VoiceClip[0]);
                break;

            case 2:
                subtitle.text = "ť������ ���� �����߽��ϴ�.";
                audioSource.PlayOneShot(VoiceClip[1]);
                break;

            case 3:
                subtitle.text = "�ƹ� �ϵ� �������ϴ�.";
                audioSource.PlayOneShot(VoiceClip[2]);
                break;

            case 4:
                subtitle.text = "ť������ �� �ູ�߰�.";
                audioSource.PlayOneShot(VoiceClip[3]);
                break;

            case 5:
                subtitle.text = "�� �ٶ�� ���� �������ϴ�.";
                audioSource.PlayOneShot(VoiceClip[4]);
                break;

            case 6:
                subtitle.text = "��� ��. ť������ ��Ҹ��� ������ϴ�.";
                audioSource.PlayOneShot(VoiceClip[5]);
                break;

            case 7:
                subtitle.text = "�� �ź��� ��Ҹ��� �ϴÿ��� ����Խ��ϴ�.";
                audioSource.PlayOneShot(VoiceClip[6]);
                break;

            case 8:
                subtitle.text = "�� �����е� �ݰ����ϴ�!";
                audioSource.PlayOneShot(VoiceClip[7]);
                break;

            case 9:
                subtitle.text = "�����е��� �߻��� ������,";
                audioSource.PlayOneShot(VoiceClip[8]);
                break;

            case 10:
                subtitle.text = "������ڿ� �������Դϴ�.";
                audioSource.PlayOneShot(VoiceClip[9]);
                break;

            case 11:
                subtitle.text = "�߰���縦 �����ϴµ� �����е�";
                audioSource.PlayOneShot(VoiceClip[10]);
                break;

            case 12:
                subtitle.text = "������ ���Կ�!";
                audioSource.PlayOneShot(VoiceClip[11]);
                break;

            case 13:
                subtitle.text = "�����е� �÷����� 2D ����";
                audioSource.PlayOneShot(VoiceClip[12]);
                break;

            case 14:
                subtitle.text = "�� �ϳ� ����������!";
                audioSource.PlayOneShot(VoiceClip[13]);
                break;

            case 15:
                subtitle.text = "�� �����̳��ƴ��� �� ��???? �׷����մϴ�~~";
                audioSource.PlayOneShot(VoiceClip[14]);
                break;

            case 16:
                subtitle.text = "�� �¾ƿ� ����! ���� �־���ؿ�!";
                audioSource.PlayOneShot(VoiceClip[15]);
                break;

            case 17:
                subtitle.text = "�� ���� ������ �з��𸶳� ���� ������ �־���ϴµ�~";
                audioSource.PlayOneShot(VoiceClip[16]);
                break;

            case 18:
                subtitle.text = "�����е� �� ����� �� �ְ���??";
                audioSource.PlayOneShot(VoiceClip[17]);
                break;

            case 19:
                subtitle.text = "�� �´� �̰� ������Դϴ�~~";
                audioSource.PlayOneShot(VoiceClip[18]);
                break;

            case 20:
                subtitle.text = "��������";
                audioSource.PlayOneShot(VoiceClip[19]);
                break;

            case 21:
                subtitle.text = "�������� ���� �׿���!";
                audioSource.PlayOneShot(VoiceClip[20]);
                break;

            case 22:
                subtitle.text = "�������� ���� �׿���! �̴̰ϴ�~~!!";
                audioSource.PlayOneShot(VoiceClip[21]);
                break;

            case 23:
                subtitle.text = "����������������������������������������������������������������������������������������������������";
                audioSource.PlayOneShot(VoiceClip[22]);
                break;

            case 24:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[23]);
                break;

            case 25:
                subtitle.text = "�ϴÿ��� ����� ��Ҹ��� ť�������� �÷��� ���Ƚ��ϴ�.";
                audioSource.PlayOneShot(VoiceClip[24]);
                break;

            case 26:
                subtitle.text = "�߰���� ��ü������� ����� ȯ���� ������ ������� ���̿����.";
                audioSource.PlayOneShot(VoiceClip[25]);
                break;

            case 27:
                subtitle.text = "ť������ 25�� ���� �ڽ��� �����α��� �������� �߽��ϴ�.";
                audioSource.PlayOneShot(VoiceClip[26]);
                break;

            case 28:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[27]);
                break;

            case 29:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[28]);
                break;

            case 30:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[29]);
                break;

            case 31:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[30]);
                break;

            case 32:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[31]);
                break;

            case 33:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[32]);
                break;

            case 34:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[33]);
                break;

            case 35:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[34]);
                break;

            case 36:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[35]);
                break;

            case 37:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[36]);
                break;

            case 38:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[37]);
                break;

            case 39:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[38]);
                break;

            case 40:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[39]);
                break;

        }
    }

}
