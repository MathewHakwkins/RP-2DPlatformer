using UnityEngine;

public class EnemyHotbox : MonoBehaviour
{
    public EnemyHealth health;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
             PlayerHealth DamageGet = collision.GetComponent<PlayerHealth>();
            PlayerController Controll = collision.GetComponent<PlayerController>();
            if ((DamageGet != null) && (Controll != null))
            {
                health.Damage(DamageGet.HitDamage);
                Controll.Jump();

            }
        }
    }
}
