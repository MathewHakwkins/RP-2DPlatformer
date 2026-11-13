using UnityEngine;

public class DamagingArea : MonoBehaviour
{
    public float DamageAmount = 1;
    public bool Projectile = false;

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
                    
                }

                


            }


        }
    }
}
