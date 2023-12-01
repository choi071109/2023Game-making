using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeAnimation : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도

    void Update()
    {
        // 현재 위치 가져오기
        Vector3 currentPosition = transform.position;

        // x축 방향으로 이동
        currentPosition.x -= moveSpeed * Time.deltaTime;

        // 변경된 위치를 적용
        transform.position = currentPosition;
    }

}
