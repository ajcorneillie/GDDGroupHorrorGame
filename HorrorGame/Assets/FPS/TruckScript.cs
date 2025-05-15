using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TruckScript : MonoBehaviour
{
    public int partsCollected = 0;

    [SerializeField]
    GameObject UI;

    [SerializeField]
    GameObject player;

    [SerializeField]
    AudioClip wind;

    [SerializeField]
    AudioClip bugs;

    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    AudioSource audioSource2;

    float maxX = 20;
    float maxZ = 20;
    float minX = -20;
    float minZ = -20;

    int timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UI.SetActive(false);
        audioSource.PlayOneShot(wind);

        audioSource.PlayOneShot(bugs);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (partsCollected == 3)
        {
            if (player.transform.position.x > transform.position.x + minX && player.transform.position.x < transform.position.x + maxX && player.transform.position.z > transform.position.z + minZ && player.transform.position.z < transform.position.z + maxZ)
            {
                UI.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    SceneManager.LoadScene("WINHorror");
                }
            }
            else
            {
                UI.SetActive(false);
            }
        }
        timer++;

        if (timer > 400)
        {
            audioSource.PlayOneShot(bugs);
            timer = 0;
        }
    }
}
