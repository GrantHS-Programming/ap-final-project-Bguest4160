using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI congrats;
    public TextMeshProUGUI highScoreText;
    public GameObject playButton;
    public GameObject gameOver;
    private int score;
    private int highScore;
    public Image start;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        highScore = 0;
        highScoreText.text = highScore.ToString();
        Pause();
        congrats.enabled = false;
        start.enabled = true;

    
    }
    public void Play()
    {
        congrats.enabled = false;
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

         Time.timeScale = 1f;
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }

        start.enabled = false;
    }


    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void GameOver()
    {
        if(highScore < score){
            highScore = score;
            highScoreText.text = highScore.ToString();
            congrats.enabled = true;
        }
        Pause();
        gameOver.SetActive(true);
        playButton.SetActive(true);
    }
    
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
