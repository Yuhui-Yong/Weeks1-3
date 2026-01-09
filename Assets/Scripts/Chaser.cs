using UnityEngine;
using UnityEngine.InputSystem;

public class Chaser : MonoBehaviour
{
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePotition = Mouse.current.position.ReadValue();
        // Using the camera to convert the mouse position from screen space (pixels) to world space (gameObjects)
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePotition);
        worldMousePosition.z = 0;

        transform.position = worldMousePosition;

        //Screen.width;
        //Screen.height;
        //gameCamera.WorldToScreenPoint(//somerandomvector);
    }
}
