using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("레이어 확인 개체")]
    public Transform groundCheck;
    public LayerMask groundLayer;

    [Header("모양")]
    public SpriteRenderer Renderer;
    public Sprite[] Shape;

    [Header("이펙트 쿨다운 텍스트")]
    public GameObject EffectText;

    [Header("사망 사운드 오디오 소스")]
    public AudioSource ClipAudioSource;
    public AudioClip[] SFXClip;

    private TextMeshProUGUI effectText;

    private float moveSpeed = 5f;
    private float jumpForce = 5f;
    private float EffectTimer = 0;
    private float Realtime = 0f;

    private string EffectName = "";

    private Rigidbody2D rb;

    private bool EffectTimerOn = false;
    private bool isGrounded;
    private bool isInvincible = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Renderer.sprite = Shape[0];
        effectText = EffectText.GetComponent<TextMeshProUGUI>();
        effectText.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.15f, groundLayer);


        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (EffectTimerOn)
        {
            EffectOn();
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Respawn":
                if (!isInvincible)
                {
                    GameOver();
                }
                break;

            case "Enemy":
                if (!isInvincible)
                {
                    GameOver();
                }
                else
                {
                    Destroy(collision.gameObject);
                }
                break;

            case "Finish":
                collision.GetComponent<LevelObject>().MoveToNextLevel();
                break;

            case "Item_Invincible":
                EffectClear();
                EffectTimerOn = true;
                Destroy(collision.gameObject);
                isInvincible = true;
                Renderer.sprite = Shape[1];
                EffectName = "불멸";
                effectText.color = Color.red;
                break;

            case "Item_Jump":
                EffectClear();
                EffectTimerOn = true;
                Destroy(collision.gameObject);
                Renderer.sprite = Shape[2];
                jumpForce = 7.5f;
                EffectName = "점프력 증가";
                effectText.color = Color.green;
                break;

            case "Item_Speed":
                EffectClear();
                EffectTimerOn = true;
                Destroy(collision.gameObject);
                Renderer.sprite = Shape[3];
                moveSpeed = 7.5f;
                EffectName = "속도 증가";
                effectText.color = Color.blue;
                break;
        }
    }

    public void EffectOn()
    {
        EffectTimer -= Time.deltaTime;
        effectText.text = $"{EffectName}\n[{EffectTimer:F4}]";

        if (EffectTimer <= 0)
        {
            EffectClear();
        }
    }
    public void EffectClear()
    {
        EffectTimerOn = false;
        isInvincible = false;
        moveSpeed = 5f;
        jumpForce = 5f;
        EffectTimer = 5f;
        Realtime = 0;
        effectText.text = " ";
        Renderer.sprite = Shape[0];
    }

    public void GameOver()
    {
        ClipAudioSource.PlayOneShot(SFXClip[UnityEngine.Random.Range(0,19)]);

        gameObject.SetActive(false);
        Invoke("RestartGame", 3.0f);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}