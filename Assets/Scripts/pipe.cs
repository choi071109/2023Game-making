using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도 조절을 위한 변수
    public float ScoreX;

    private bool check = false;
    void Update()
    {
        // 현재 위치에서 계속해서 왼쪽으로 이동
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // 현재 오브젝트의 X 좌표가 -10 이하인지 확인
        if (transform.position.x <= -10f)
        {
            // X 좌표가 -10 이하일 때 자신을 삭제
            Destroy(gameObject);
        }

        // 현재 위치가 scorex보다 작으면
        if (transform.position.x <= ScoreX && !check)
        {
            //게임 매니저의 점수를 증가시켜라
            GameManager.score++;
            check = true;
        }
    }
}