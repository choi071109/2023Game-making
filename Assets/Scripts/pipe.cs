using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ� ������ ���� ����
    public float ScoreX;

    private bool check = false;
    void Update()
    {
        // ���� ��ġ���� ����ؼ� �������� �̵�
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // ���� ������Ʈ�� X ��ǥ�� -10 �������� Ȯ��
        if (transform.position.x <= -10f)
        {
            // X ��ǥ�� -10 ������ �� �ڽ��� ����
            Destroy(gameObject);
        }

        // ���� ��ġ�� scorex���� ������
        if (transform.position.x <= ScoreX && !check)
        {
            //���� �Ŵ����� ������ �������Ѷ�
            GameManager.score++;
            check = true;
        }
    }
}