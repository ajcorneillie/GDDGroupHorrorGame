using UnityEngine;

public class WinScreenEscapeDrive : MonoBehaviour
{
    [SerializeField]
    private float escapeSpeed = 2.5f;
    
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + escapeSpeed);
    }
}
