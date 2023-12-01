using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI GameScoreText;
    public static int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GameScoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        // ���� ���� �ٽ� �ε��Ͽ� ������ �����
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        Time.timeScale = 1.0f; // ���� �ð��� �����Ŵ
    }
}