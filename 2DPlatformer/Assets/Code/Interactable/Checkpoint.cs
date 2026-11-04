using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public ParticleSystem Partical;
    private Vector2 CheckpoinPosition;

    private void Awake()
    {
        CheckpoinPosition = transform.position;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth TargetHealth = collision.GetComponent<PlayerHealth>();
            if (TargetHealth != null)
            {
                TargetHealth.RespawnPoint = CheckpoinPosition;
                Partical.Play();
            }
        }
    }
}
