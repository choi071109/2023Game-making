using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 5f; // ������ ���� ���� ũ��

    private Rigidbody2D rb;

    public GameObject gameOverImage;
    public GameObject restartButton;

    void Start()
    {
        // Rigidbody2D ������Ʈ�� �����ɴϴ�.
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // �����̽� �ٸ� ������ �� ������ �����մϴ�.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }


    }

    void Jump()
    {
        // Rigidbody2D�� ���� �������� ���� ���� ������Ʈ�� ������ŵ�ϴ�.
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    // �浹�� �߻����� �� ȣ��Ǵ� �Լ�
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ���⿡ �浹 ó�� �ڵ带 �߰��մϴ�.

        // ���� ���, �浹�� �߻��ϸ� ������ ���ߴ� �ڵ�
        Time.timeScale = 0f; // ���� �ð��� ������Ŵ

        gameOverImage.SetActive(true);
        restartButton.SetActive(true);
    }
}
