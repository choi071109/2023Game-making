using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnimation : MonoBehaviour
{
    public float scrollSpeed = 0.5f; // Texture�� Offset x ���� ������ �ӵ�
    private MeshRenderer meshRenderer;

    void Start()
    {
        // Start���� �� ���� Mesh Renderer�� ��������
        meshRenderer = GetComponent<MeshRenderer>();

        if (meshRenderer == null)
        {
            Debug.LogError("Mesh Renderer�� �����ϴ�.");
        }
    }

    void Update()
    {
        if (meshRenderer != null)
        {
            // ���� Material�� Offset ���� ��������
            Vector2 offset = meshRenderer.material.mainTextureOffset;

            // Offset x ���� ����
            offset.x -= scrollSpeed * Time.deltaTime;

            // ����� Offset ���� Material�� ����
            meshRenderer.material.mainTextureOffset = offset;
        }
    }
}


