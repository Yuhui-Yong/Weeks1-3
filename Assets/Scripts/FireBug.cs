using UnityEngine;
using UnityEngine.InputSystem;

public class FireBug : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()); // Get the mouse location and make the mouse's coordinate be in the world screen.
        mousePos.z = 0; // Set the mousePos.z value as zero since mouse only exists in 2D and we also only making a 2D game, and if z value got changed, the object would disappear or something.
        transform.position = mousePos; // Now, make the object's coordinate as mouse's location.
    }
}
