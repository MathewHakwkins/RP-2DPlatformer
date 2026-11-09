using UnityEngine;

public class HoverBehavior : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Player;


    private GameObject Moveto;


    private void Awake()
    {
        Moveto = Target2;



    }


    private void Movement()
    {
        if (Player != null)
        {

        }

    }

    private void SpawnProjectile(GameObject Target)
    {
        if ((Projectile != null) && (Projectile.GetComponent("ProjectileMovement")))
        {
            

            

        }
    }
}
