using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int Score;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController AddScoreTo = collision.GetComponent<PlayerController>();
            if (AddScoreTo != null)
            {
                AddScoreTo.Addscore(Score);
                Destroy(gameObject);
            }
        }
    }
}
