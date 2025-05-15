using UnityEngine;

public class CursorUnlock : MonoBehaviour
{
    void Start()
    {
        // Make the cursor visible and unlock it
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
