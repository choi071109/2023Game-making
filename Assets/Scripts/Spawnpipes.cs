using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    public GameObject prefabToSpawn; // ������ ������
    public float spawnInterval = 3f; // ���� ���� (��)

    void Start()
    {
        // �ֱ������� SpawnPrefab �Լ� ȣ��
        InvokeRepeating("SpawnPrefab", 0f, spawnInterval);
    }

    void SpawnPrefab()
    {

        // �������� Y ��ǥ ���� (-1.3���� 3����)
        float randomY = Random.Range(-1.3f, 3f);

        // ������ ����
        GameObject newPrefab = Instantiate(prefabToSpawn, new Vector2(transform.position.x, randomY), Quaternion.identity);
    }
}