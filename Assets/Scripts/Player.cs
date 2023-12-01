using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 5f; // 점프에 사용될 힘의 크기

    private Rigidbody2D rb;

    public GameObject gameOverImage;
    public GameObject restartButton;

    void Start()
    {
        // Rigidbody2D 컴포넌트를 가져옵니다.
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 스페이스 바를 눌렀을 때 점프를 수행합니다.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }


    }

    void Jump()
    {
        // Rigidbody2D에 위쪽 방향으로 힘을 가해 오브젝트를 점프시킵니다.
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    // 충돌이 발생했을 때 호출되는 함수
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 여기에 충돌 처리 코드를 추가합니다.

        // 예를 들어, 충돌이 발생하면 게임을 멈추는 코드
        Time.timeScale = 0f; // 게임 시간을 정지시킴

        gameOverImage.SetActive(true);
        restartButton.SetActive(true);
    }
}
