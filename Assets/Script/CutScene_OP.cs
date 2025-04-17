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

    [Header("이미지 소스")]

    public Image ImageSource;
    public Sprite[] Image;

    [Header("자막 텍스트")]
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

                subtitle.text = "큐보리는 하얀 방에서 살고 있었습니다.";
                audioSource.PlayOneShot(VoiceClip[0]);
                break;

            case 90:
                subtitle.text = "큐보리의 방은 조용했습니다.";
                audioSource.PlayOneShot(VoiceClip[1]);
                break;

            case 150:
                subtitle.text = "아무 일도 없었습니다.";
                audioSource.PlayOneShot(VoiceClip[2]);
                break;

            case 200:
                subtitle.text = "어느 날.";
                audioSource.PlayOneShot(VoiceClip[4]);
                break;

            case 220:
                subtitle.text = subtitle.text+" 큐보리는 목소리를 들었습니다.";
                break;

            case 265:
                subtitle.text = "이 신비한 목소리는 하늘에서 들려왔습니다.";
                audioSource.PlayOneShot(VoiceClip[5]);
                break;

            case 330:
                StartCoroutine(VoiceClip6_Subtitle());
                break;

            case 1130:
                subtitle.text = "하늘에서 들려온 목소리는 큐보리에게 시련을 내렸습니다.";
                audioSource.PlayOneShot(VoiceClip[7]);
                break;

            case 1212:
                subtitle.text = "중간고사 대체과제라는 험악한 환경을";
                audioSource.PlayOneShot(VoiceClip[8]);
                break;

            case 1275:
                subtitle.text = "파헤쳐 나가라는 것이였습니다.";
                break;

            case 1322:
                subtitle.text = "그렇게 큐보리는 25년 만에";
                audioSource.PlayOneShot(VoiceClip[9]);
                break;

            case 1377:
                subtitle.text = "자신의";
                break;

            case 1387:
                subtitle.text += " 대퇴사두근을";
                break;

            case 1404:
                subtitle.text += " 움직여야했습니다. ㅋㅋㅋㅋ";
                break;

            case 1462:
                subtitle.text = "...";
                break;
        }
    }
    IEnumerator VoiceClip6_Subtitle()
    {
        audioSource.PlayOneShot(VoiceClip[6]);
        subtitle.text = "자 여러분들 반갑습니다!";
        yield return Sleep(1.75);
        subtitle.text = "여러분들의 잘★생★긴 교수님";
        yield return Sleep(1.75);
        subtitle.text = "★★★Za★★★";
        yield return Sleep(0.25);
        subtitle.text = "유★재★원 교수님입니다.";
        yield return Sleep(2);
        subtitle.text = "중간고사를 봐야하는데 여러분들";
        yield return Sleep(2.4);
        subtitle.text = "과@제를 하나만 낼게요";
        yield return Sleep(1.0);
        subtitle.text = "아잃;; ㅎㅎㅎㅎㅎㅎㅎ";
        yield return Sleep(1.0);
        subtitle.text = "여ㅋ러분들 플랫포머 2D 게임";
        yield return Sleep(2.0);
        subtitle.text = "딱 하나만 만들어오세요!";
        yield return Sleep(1.1);
        subtitle.text = "하.나.만";
        yield return Sleep(1.0);
        subtitle.text = "막 적들이날아댕기고 막 어????";
        yield return Sleep(2.25);
        subtitle.text = "그래야댑니다~";
        yield return Sleep(1);
        subtitle.text = "그리고 막 적들이 막 쫒아와야 해요!";
        yield return Sleep(1.75);
        subtitle.text = "아마자요!!";
        yield return Sleep(0.4);
        subtitle.text = "(박수짝)";
        yield return Sleep(0.25);
        subtitle.text = "함정! 함@정 있어야해요!! 함@@@정";
        yield return Sleep(2.25);
        subtitle.text = "막";
        yield return Sleep(0.2);
        subtitle.text += " 슈퍼 마리오";
        yield return Sleep(0.4);
        subtitle.text += " 패러디마냥";
        yield return Sleep(0.7);
        subtitle.text += " 무적 아이템 있어야하는데;;";
        yield return Sleep(1);
        subtitle.text = "여러분들";
        yield return Sleep(1);
        subtitle.text = "아~ 그";
        yield return Sleep(0.05);
        subtitle.text += " 잘 만드실";
        yield return Sleep(0.05);
        subtitle.text += " 잘...";
        yield return Sleep(1.5);
        subtitle.text = "(휴먼 에러)";
        yield return Sleep(0.7);
        subtitle.text = "잘 만드실 수 있겠죠???";
        yield return Sleep(1.7);
        subtitle.text = "아맞다이거";
        yield return Sleep(0.75);
        subtitle.text = "아~~ 이거 맞다!";
        yield return Sleep(0.6);
        subtitle.text = "이거 상대평가입니다";
        yield return Sleep(0.9);
        subtitle.text += " 상대평가";
        yield return Sleep(1.3);
        subtitle.text = "이제부터";
        yield return Sleep(0.9);
        subtitle.text += " 서로";
        yield return Sleep(0.4);
        subtitle.text += " 쮹@123이면 됩니다!!";
        yield return Sleep(1.75);
        subtitle.text = "이야!@!!!!!!";
        for (int i = 0; i < 10; i++)
        {
            yield return Sleep(0.02);
            subtitle.text = "ㅋㅋㅋㅋㅋㅋㅋㅋ";
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
