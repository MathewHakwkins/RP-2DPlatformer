using Unity.VisualScripting;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{

    private Vector2 PointSpawn;
    public Vector2 PointEnd;
    public float speed = 1;

    private Vector2 nextPoint;

    public float DamageAmount = 1;
    

    public GameObject Parent;








    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            PlayerHealth TargetHealth = collision.GetComponent<PlayerHealth>();
            PlayerController Controll = collision.GetComponent<PlayerController>();

            if ((Controll != null) && (TargetHealth != null))
            {

                if (TargetHealth.InvulFrames <= 0)
                {
                    TargetHealth.Damage(DamageAmount);
                    Controll.Jump();
                    transform.position = PointSpawn;

                }

            }


        }
    }

    private void Awake()
    {
        PointSpawn = Parent.transform.position;
        nextPoint = PointEnd;
    }


    private void Update()
    {


        transform.position = Vector2.MoveTowards(transform.position, nextPoint, speed * Time.deltaTime);
        if (transform.position == new Vector3(nextPoint.x, nextPoint.y, 0))
        {

            transform.position = PointSpawn;
        }

    }








}
