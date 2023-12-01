using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnimation : MonoBehaviour
{
    public float scrollSpeed = 0.5f; // Texture의 Offset x 값을 조절할 속도
    private MeshRenderer meshRenderer;

    void Start()
    {
        // Start에서 한 번만 Mesh Renderer를 가져오기
        meshRenderer = GetComponent<MeshRenderer>();

        if (meshRenderer == null)
        {
            Debug.LogError("Mesh Renderer가 없습니다.");
        }
    }

    void Update()
    {
        if (meshRenderer != null)
        {
            // 현재 Material의 Offset 값을 가져오기
            Vector2 offset = meshRenderer.material.mainTextureOffset;

            // Offset x 값을 조절
            offset.x -= scrollSpeed * Time.deltaTime;

            // 변경된 Offset 값을 Material에 적용
            meshRenderer.material.mainTextureOffset = offset;
        }
    }
}


