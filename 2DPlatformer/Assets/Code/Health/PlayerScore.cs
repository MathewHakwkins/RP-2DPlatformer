using UnityEngine;
using TMPro;
using System;
public class PlayerScore : MonoBehaviour
{
    public PlayerHealth health;
    public int Score = 0;

    public TMP_Text ScoreCount;

    public void UpScore(int ScoreAmount)
    {
        Score += ScoreAmount;
        if (Score >= 100)
        {
            health.HealLives(1);
            Score -= 100;
        }

        ScoreCount.text = Convert.ToString(Score);
    }

}
