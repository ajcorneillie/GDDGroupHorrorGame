using UnityEngine;

public class CarPartScript : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject truck;

    [SerializeField]
    GameObject UI;

    bool activateOnce = false;

    float maxX = 10;
    float maxZ = 10;
    float minX = -10;
    float minZ = -10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x > transform.position.x + minX && player.transform.position.x < transform.position.x + maxX && player.transform.position.z > transform.position.z + minZ && player.transform.position.z < transform.position.z + maxZ)
        {
            UI.SetActive(true);
            activateOnce = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                truck.GetComponent<TruckScript>().partsCollected = truck.GetComponent<TruckScript>().partsCollected + 1;
                UI.SetActive(false);
                Destroy(gameObject);
            }
        }
        else
        {
            if (activateOnce == true)
            {
                activateOnce = false;
                UI.SetActive(false);
            }
        }
    }
}
