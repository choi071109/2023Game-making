using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    public GameObject prefabToSpawn; // 생성할 프리팹
    public float spawnInterval = 3f; // 생성 간격 (초)

    void Start()
    {
        // 주기적으로 SpawnPrefab 함수 호출
        InvokeRepeating("SpawnPrefab", 0f, spawnInterval);
    }

    void SpawnPrefab()
    {

        // 랜덤으로 Y 좌표 설정 (-1.3부터 3까지)
        float randomY = Random.Range(-1.3f, 3f);

        // 프리팹 생성
        GameObject newPrefab = Instantiate(prefabToSpawn, new Vector2(transform.position.x, randomY), Quaternion.identity);
    }
}