using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject Boss;

    private void Update()
    {
        if (Boss == null)
        {
            Destroy(gameObject);
        }
    }
}
