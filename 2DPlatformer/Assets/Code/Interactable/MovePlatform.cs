using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public GameObject Target1;

    private void Awake()
    {
        if (Target1 == null)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Vector2.MoveTowards(gameObject.transform.position, Target1.transform.position, Time.deltaTime);


        }

    }



}
