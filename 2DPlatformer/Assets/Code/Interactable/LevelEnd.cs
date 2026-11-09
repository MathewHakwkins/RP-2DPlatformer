using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public string LevelName;

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if(Collision.CompareTag("Player"))
        {

            
            LoadLevel();

        }
        
    }






    private void LoadLevel()
    {
        
        SceneManager.LoadScene(LevelName);

    }
}
