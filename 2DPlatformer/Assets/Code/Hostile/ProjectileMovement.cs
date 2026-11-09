using Unity.VisualScripting;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    

    public void FireatTarget(Vector2 TargetLocation)
    {
        transform.position = Vector2.MoveTowards(gameObject.transform.position, TargetLocation, 100000);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            return;

        }
        else
        {
            Destroy(gameObject);
        }
    }

}
