using Unity.VisualScripting;
using UnityEngine;

public class JumpPad : MonoBehaviour
{

    public float Poweramount = 2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController Controll = collision.GetComponent<PlayerController>();

            if (Controll != null)
            {
                Controll.MegaJump(Poweramount);

            }

        }
    }
}
