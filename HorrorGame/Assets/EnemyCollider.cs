using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            SceneManager.LoadScene("LOSSHorror");
        }
    }
}
