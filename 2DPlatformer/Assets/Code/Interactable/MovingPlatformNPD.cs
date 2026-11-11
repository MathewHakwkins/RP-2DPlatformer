using UnityEngine;

public class MovingPlatformNPD : MonoBehaviour
{
    public Vector2 PointA;
    public Vector2 PointB;
    public float speed = 1;

    private Vector2 nextPoint;

    
    private void Awake()
    {
        nextPoint = PointA;
    }

    
    private void Update()
    {
        
        
       transform.position = Vector2.MoveTowards(transform.position, nextPoint, speed * Time.deltaTime);
       if (transform.position == new Vector3(nextPoint.x, nextPoint.y, 0))
        {

           if (nextPoint == PointA)
           {

              nextPoint = PointB;

           }
           else
           {
              nextPoint = PointA;
           }
        }
        
    }
}
