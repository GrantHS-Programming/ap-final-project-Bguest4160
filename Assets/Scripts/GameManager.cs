using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    private int score;

    private void Awake()
    {

    }
    public void Play()
    {
        
    }
    public void GameOver()
    {
        Debug.Log("Game over");
    }
    
    public void IncreaseScore()
    {
        score++;
    }
}
