using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.TextCore;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;

public class ScoreKeeper : MonoBehaviour
{
    public GameObject player;
    public Text score;
    public Text gameOverScore;
    public Text playerTotalTime;
    public Text enemiesKilled;
    public int scoreCount = 0;
    public float playerTime;
    public int totalKills = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
        score.text = string.Format("Score: {0}", scoreCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.gameObject.GetComponent<PlayerHealth>().currentHealth > 0) 
        {
            playerTime = Time.unscaledTime;
        }
        int intMinute = (int)playerTime / 60;
        int intSeconds = (int)playerTime % 60;
        playerTotalTime.text = string.Format("Time Survived : {0}m {1}s",intMinute, intSeconds) ;
        score.text = string.Format("Score: {0}", TotalScore(0));
        gameOverScore.text = string.Format("Score: {0}", scoreCount);
        enemiesKilled.text = string.Format("Enemies Killed : {0}" , Kills(0));

    }

    
    public int Kills(int Kills)
    {
        return totalKills += Kills;
    }
    public int TotalScore(int customScore)
    {
        return scoreCount += customScore;
    }
}
