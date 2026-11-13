using UnityEngine;

public class TimedPlatform : MonoBehaviour
{
    public float Life = 100;

    public float Fade = 1;
    private bool PlayerOn = false;
    private SpriteRenderer Renderer;

    private float Oppasity = 255;

    private void Awake()
    {
        Renderer = GetComponent<SpriteRenderer>();
    }

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
            Oppasity -= Time.deltaTime * Fade;
            

            if  (Life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}


