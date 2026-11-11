using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 2;
    public Vector2 RespawnPoint = Vector2.zero;
    public float InvulFrames = 0;
    public float MaxInvul = 1;
    public float Lives = 2;
    public float HitDamage = 1;

    private float RespawnHealth = 2;


    private void Update()
    {
        if (InvulFrames > 0)
        {
            InvulFrames -= Time.deltaTime;
        }
    }


    public void Damage(float DamageAmount)
    {
        
        health -= DamageAmount;
        if ((health <= 0) && (Lives <= 0))
        {
            Die();
        }
        else if ((health <= 0) && (Lives > 0))
        {
            Respawn();
            Lives -= 1;
            health = RespawnHealth;
        }
        else
        {
            InvulFrames = MaxInvul;
        }
    }

    public void HealHealth(float HealAmount)
    {
        health += HealAmount;
    }


    public void HealLives(float HealAmount)
    {
        Lives += HealAmount;
    }


    private void Respawn()
    {
        gameObject.transform.position = RespawnPoint;
    }



    private void Die()
    {
        Destroy(gameObject);
    }

}
