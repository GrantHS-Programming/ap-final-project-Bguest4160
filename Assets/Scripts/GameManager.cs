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
    public GameObject easy;
    public GameObject medium;
    public GameObject hard;
    public GameObject playAgainButton;
    private int score;
    private int highScore;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        highScore = 0;
        highScoreText.text = highScore.ToString();
        Pause();
        congrats.enabled = false;
        easy.SetActive(false);
        medium.SetActive(false);
        hard.SetActive(false);
        playAgainButton.SetActive(false);

    
    }
    public void Play()
    {
        congrats.enabled = false;
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        easy.SetActive(true);
        medium.SetActive(true);
        hard.SetActive(true);

        
    }
    public void PlayEasy()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }
        easy.SetActive(false);
        medium.SetActive(false);
        hard.SetActive(false);
    }
     public void PlayMedium()
    {
        
        Time.timeScale = 1f;
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }
        easy.SetActive(false);
        medium.SetActive(false);
        hard.SetActive(false);
    }
     public void PlayHard()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }
        easy.SetActive(false);
        medium.SetActive(false);
        hard.SetActive(false);
    }
    public void PlayAgain()
    {
        congrats.enabled = false;
        score = 0;
        scoreText.text = score.ToString();

        playAgainButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }
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
        playAgainButton.SetActive(true);
    }
    
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
