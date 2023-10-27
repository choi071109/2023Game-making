using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 5.0f; // 점프 힘 조절용 변수
    private bool isGrounded; // 지면과 접촉 여부를 판단할 변수
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 스페이스 키를 누를 때 점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // Rigidbody2D를 사용하여 오브젝트를 점프시킴
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isGrounded = false;
    }


}
