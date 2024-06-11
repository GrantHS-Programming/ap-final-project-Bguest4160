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
    public GameObject firework1;

    public GameObject firework2;
    public TextMeshProUGUI fail;
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
        fail.enabled = false;
        start.enabled = true;
        firework1.SetActive(false);
        firework2.SetActive(false);

    
    }
    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        firework1.SetActive(false);
        firework2.SetActive(false);
        playButton.SetActive(false);
        gameOver.SetActive(false);
        congrats.enabled = false;
        fail.enabled = false;

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
        player.enabled = false;
        Time.timeScale = 0f;
    }
    public void GameOver()
    {
        if(highScore < score){
            highScore = score;
            highScoreText.text = highScore.ToString();
            congrats.enabled = true;
            firework1.SetActive(true);
            firework2.SetActive(true);
        }
        else{
            fail.enabled = true;
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
