using UnityEngine;

public class LightFollow : MonoBehaviour
{
    [SerializeField]
    GameObject obj;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = obj.transform.position;
        transform.rotation = obj.transform.rotation;
    }
}
