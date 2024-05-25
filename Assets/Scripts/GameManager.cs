using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int targetScore;
    public GameObject winPanel;
    public GameObject losePanel;

    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI targetScoreText;

    public GameObject egg;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;

    bool gameStarted = false;
    private void Start()
    {
        Time.timeScale = 1;
        targetScore = Random.Range(50, 101); // 50 ile 100 arasýnda rastgele bir sayý üret
        targetScoreText.text = "Target Score: " + targetScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartSpawning();
            gameStarted = true;
        }
        scoreText.text = "Score: " + score.ToString();
        if (score == targetScore)
        {
            Debug.Log("Kazandýn!");
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (score > targetScore)
        {
            Debug.Log("Kaybettin!");
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }


    private void StartSpawning()
    {
        InvokeRepeating("SpawnEgg", 0.5f, spawnRate);
    }


    private void SpawnEgg()
    {
        Vector2 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate(egg, spawnPos, Quaternion.identity);
    }
    public void TekrarOyna()
    {
        SceneManager.LoadScene(1);
    }
}