using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeAnimation : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ�

    void Update()
    {
        // ���� ��ġ ��������
        Vector3 currentPosition = transform.position;

        // x�� �������� �̵�
        currentPosition.x -= moveSpeed * Time.deltaTime;

        // ����� ��ġ�� ����
        transform.position = currentPosition;
    }

}
