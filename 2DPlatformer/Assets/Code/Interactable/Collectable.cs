using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int Score;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerScore AddScoreTo = collision.GetComponent<PlayerScore>();
            if (AddScoreTo != null)
            {
                AddScoreTo.UpScore(Score);
                Destroy(gameObject);
            }
        }
    }
}
