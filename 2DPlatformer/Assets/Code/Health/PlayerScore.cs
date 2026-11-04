using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public PlayerHealth health;
    public int Score = 0;

    public void UpScore(int ScoreAmount)
    {
        Score += ScoreAmount;
        if (Score >= 100)
        {
            health.HealLives(1);
            Score -= 100;
        }
    }

}
