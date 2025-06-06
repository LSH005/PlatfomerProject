using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutScene_ED : MonoBehaviour
{
    [Header("左戚什適験 神巨神 社什")]
    public AudioSource VoiceClipAudioSource;
    public AudioClip[] VoiceClip;

    [Header("BGM 神巨神 社什")]
    public AudioSource BGMAudioSource;
    public AudioClip BGM;

    [Header("戚耕走 社什")]

    public Image ImageSource;
    public Sprite[] Image;

    [Header("切厳 努什闘")]
    public GameObject SubtitleText;

    [Header("UI 努什闘")]
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
            infoText.text = "什典 掻!";
            if (SkipScene >= 1.0f)
            {
                SceneManager.LoadScene("Lv_1");
            }
        }
        else
        {
            SkipScene = 0f;
            infoText.text = "什凪戚什 郊研 掩惟 喚君辞 什典";
        }
    }


    public void CutSceneAudioAct()
    {
        switch (VoiceTick)
        {
            case 30:
                Camera.main.backgroundColor = Color.white;

                subtitle.text = "泥左軒澗 馬鍾 号拭辞 詞壱 赤醸柔艦陥.";
                ImageSource.sprite = Image[0];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[0]);
                break;

            case 90:
                subtitle.text = "泥左軒税 号精 繕遂梅柔艦陥.";
                ImageSource.sprite = Image[1];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[1]);
                break;

            case 140:
                subtitle.text = "焼巷 析亀 蒸醸柔艦陥.";
                ImageSource.sprite = Image[2];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[2]);
                break;

            case 200:
                subtitle.text = "嬢汗 劾.";
                VoiceClipAudioSource.PlayOneShot(VoiceClip[4]);
                break;

            case 220:
                subtitle.text = subtitle.text + " 泥左軒澗 鯉社軒研 級醸柔艦陥.";
                ImageSource.sprite = Image[3];
                break;

            case 265:
                subtitle.text = "戚 重搾廃 鯉社軒澗 馬潅拭辞 級形尽柔艦陥.";
                ImageSource.sprite = Image[8];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[5]);
                break;

            case 330:
                StartCoroutine(VoiceClip6_Subtitle());
                BGMAudioSource.Pause();
                break;

            case 1130:
                subtitle.text = "馬潅拭辞 級形紳 鯉社軒澗 泥左軒拭惟 獣恵聖 鎧携柔艦陥.";
                ImageSource.sprite = Image[9];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[7]);
                BGMAudioSource.UnPause();
                break;

            case 1212:
                subtitle.text = "掻娃壱紫 企端引薦虞澗 蝿焦廃 発井聖";
                ImageSource.sprite = Image[10];
                VoiceClipAudioSource.PlayOneShot(VoiceClip[8]);
                break;

            case 1275:
                subtitle.text = "督伯団 蟹亜虞澗 依戚心柔艦陥.";
                break;

            case 1322:
                subtitle.text = "益係惟 泥左軒澗 25鰍 幻拭";
                VoiceClipAudioSource.PlayOneShot(VoiceClip[9]);
                break;

            case 1377:
                subtitle.text = "切重税";
                break;

            case 1387:
                subtitle.text += " 企盗紫砧悦聖";
                BGMAudioSource.Stop();
                ImageSource.sprite = Image[11];
                break;

            case 1404:
                subtitle.text += " 崇送食醤梅柔艦陥.";
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
        subtitle.text = "切 食君歳級 鋼逢柔艦陥!";
        yield return Sleep(1.75);
        subtitle.text = "食君歳級税 設【持【延 嘘呪還";
        yield return Sleep(1.75);
        subtitle.text = "【【【Za【【【";
        yield return Sleep(0.25);
        subtitle.text = "政【仙【据 嘘呪還脊艦陥.";
        yield return Sleep(2);
        subtitle.text = "掻娃壱紫研 坐醤馬澗汽 食君歳級";
        yield return Sleep(2.4);
        subtitle.text = "引@薦研 馬蟹幻 馨惟推";
        yield return Sleep(1.0);
        subtitle.text = "焼籍;; ぞぞぞぞぞぞぞ";
        yield return Sleep(1.0);
        subtitle.text = "食せ君歳級 巴熊匂袴 2D 惟績";
        yield return Sleep(2.0);
        subtitle.text = "亨 馬蟹幻 幻級嬢神室推!";
        yield return Sleep(1.1);
        subtitle.text = "馬.蟹.幻";
        yield return Sleep(1.0);
        subtitle.text = "厳 旋級戚劾焼寄奄壱 厳 嬢????";
        yield return Sleep(2.25);
        subtitle.text = "益掘醤基艦陥~";
        yield return Sleep(1);
        subtitle.text = "益軒壱 厳 旋級戚 厳 �i焼人醤 背推!";
        yield return Sleep(1.75);
        subtitle.text = "焼原切推!!";
        yield return Sleep(0.4);
        subtitle.text = "(酵呪側)";
        yield return Sleep(0.25);
        subtitle.text = "敗舛! 敗@舛 赤嬢醤背推!! 敗@@@舛";
        yield return Sleep(2.25);
        subtitle.text = "厳";
        yield return Sleep(0.2);
        subtitle.text += " 輯遁 原軒神";
        yield return Sleep(0.4);
        subtitle.text += " 鳶君巨原撹";
        yield return Sleep(0.7);
        subtitle.text += " 巷旋 焼戚奴 赤嬢醤馬澗汽;;";
        yield return Sleep(1);
        subtitle.text = "食君歳級";
        yield return Sleep(1);
        subtitle.text = "焼~ 益";
        yield return Sleep(0.05);
        subtitle.text += " 設 幻球叔";
        yield return Sleep(0.05);
        subtitle.text += " 設...";
        yield return Sleep(1.5);
        subtitle.text = "(妃胡 拭君)";
        yield return Sleep(0.7);
        subtitle.text = "設 幻球叔 呪 赤畏倉???";
        yield return Sleep(1.7);
        subtitle.text = "焼限陥戚暗";
        yield return Sleep(0.75);
        subtitle.text = "焼~~ 戚暗 限陥!";
        yield return Sleep(0.6);
        subtitle.text = "戚暗 雌企汝亜脊艦陥";
        yield return Sleep(0.9);
        subtitle.text += " 雌企汝亜";
        yield return Sleep(1.3);
        subtitle.text = "戚薦採斗";
        yield return Sleep(0.9);
        subtitle.text += " 辞稽";
        yield return Sleep(0.4);
        subtitle.text += " 宋【戚【檎 桔艦陥!!";
        yield return Sleep(1.75);
        subtitle.text = "⊂⊂ 嘘呪還 紫櫛杯艦陥 ⊂⊂";
        for (int i = 0; i < 10; i++)
        {
            yield return Sleep(0.02);
            subtitle.text = "戚醤!!!!!!!!!!!!!!!!!!";
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
