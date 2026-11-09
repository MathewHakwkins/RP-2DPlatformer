using UnityEngine;

public class TimedPlatform : MonoBehaviour
{
    public float Life = 100;
    private bool PlayerOn = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerOn = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerOn = false;

        }
    }

    private void Update()
    {
        if (PlayerOn)
        {
            Life -= Time.deltaTime;

            if (Life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}


