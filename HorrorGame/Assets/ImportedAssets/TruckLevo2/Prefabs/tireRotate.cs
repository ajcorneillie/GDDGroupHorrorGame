using UnityEngine;

public class tireRotate : MonoBehaviour
{
    Vector3 rotationSpeed = new Vector3(-1500, 0, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles + rotationSpeed * Time.deltaTime;

        transform.eulerAngles = newRotation;
    }
}
