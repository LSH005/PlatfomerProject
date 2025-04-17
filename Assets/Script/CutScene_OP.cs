using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CutScene_OP : MonoBehaviour
{
    [Header("오디오 소스")]
    public AudioSource audioSource;
    public AudioClip[] VoiceClip;

    [Header("자막 텍스트")]
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
                subtitle.text = "큐보리는 하얀 방에서 살고 있었습니다.";
                audioSource.PlayOneShot(VoiceClip[0]);
                break;

            case 2:
                subtitle.text = "큐보리의 방은 조용했습니다.";
                audioSource.PlayOneShot(VoiceClip[1]);
                break;

            case 3:
                subtitle.text = "아무 일도 없었습니다.";
                audioSource.PlayOneShot(VoiceClip[2]);
                break;

            case 4:
                subtitle.text = "큐보리는 꽤 행복했고.";
                audioSource.PlayOneShot(VoiceClip[3]);
                break;

            case 5:
                subtitle.text = "더 바라는 것은 없었습니다.";
                audioSource.PlayOneShot(VoiceClip[4]);
                break;

            case 6:
                subtitle.text = "어느 날. 큐보리는 목소리를 들었습니다.";
                audioSource.PlayOneShot(VoiceClip[5]);
                break;

            case 7:
                subtitle.text = "이 신비한 목소리는 하늘에서 들려왔습니다.";
                audioSource.PlayOneShot(VoiceClip[6]);
                break;

            case 8:
                subtitle.text = "자 여러분들 반갑습니다!";
                audioSource.PlayOneShot(VoiceClip[7]);
                break;

            case 9:
                subtitle.text = "여러분들의 잘생긴 교수님,";
                audioSource.PlayOneShot(VoiceClip[8]);
                break;

            case 10:
                subtitle.text = "유★재★원 교수님입니다.";
                audioSource.PlayOneShot(VoiceClip[9]);
                break;

            case 11:
                subtitle.text = "중간고사를 봐야하는데 여러분들";
                audioSource.PlayOneShot(VoiceClip[10]);
                break;

            case 12:
                subtitle.text = "과제를 낼게요!";
                audioSource.PlayOneShot(VoiceClip[11]);
                break;

            case 13:
                subtitle.text = "여러분들 플랫포머 2D 게임";
                audioSource.PlayOneShot(VoiceClip[12]);
                break;

            case 14:
                subtitle.text = "딱 하나 만들어오세요!";
                audioSource.PlayOneShot(VoiceClip[13]);
                break;

            case 15:
                subtitle.text = "막 적들이날아댕기고 막 어???? 그래야합니다~~";
                audioSource.PlayOneShot(VoiceClip[14]);
                break;

            case 16:
                subtitle.text = "아 맞아요 함정! 함정 있어야해요!";
                audioSource.PlayOneShot(VoiceClip[15]);
                break;

            case 17:
                subtitle.text = "막 슈퍼 마리오 패러디마냥 무적 아이템 있어야하는데~";
                audioSource.PlayOneShot(VoiceClip[16]);
                break;

            case 18:
                subtitle.text = "여러분들 잘 만드실 수 있겠죠??";
                audioSource.PlayOneShot(VoiceClip[17]);
                break;

            case 19:
                subtitle.text = "아 맞다 이거 상대평가입니다~~";
                audioSource.PlayOneShot(VoiceClip[18]);
                break;

            case 20:
                subtitle.text = "이제부터";
                audioSource.PlayOneShot(VoiceClip[19]);
                break;

            case 21:
                subtitle.text = "이제부터 서로 죽여라!";
                audioSource.PlayOneShot(VoiceClip[20]);
                break;

            case 22:
                subtitle.text = "이제부터 서로 죽여라! 이겁니다~~!!";
                audioSource.PlayOneShot(VoiceClip[21]);
                break;

            case 23:
                subtitle.text = "ㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋ";
                audioSource.PlayOneShot(VoiceClip[22]);
                break;

            case 24:
                subtitle.text = "";
                audioSource.PlayOneShot(VoiceClip[23]);
                break;

            case 25:
                subtitle.text = "하늘에서 들려온 목소리는 큐보리에게 시련을 내렸습니다.";
                audioSource.PlayOneShot(VoiceClip[24]);
                break;

            case 26:
                subtitle.text = "중간고사 대체과제라는 험악한 환경을 파해쳐 나가라는 것이였어요.";
                audioSource.PlayOneShot(VoiceClip[25]);
                break;

            case 27:
                subtitle.text = "큐보리는 25년 만에 자신의 대퇴사두근을 움직여야 했습니다.";
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
