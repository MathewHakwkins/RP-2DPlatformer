using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Health = 1;




    


    public void Damage(float damageamount)
    {
        Health -= damageamount;

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
