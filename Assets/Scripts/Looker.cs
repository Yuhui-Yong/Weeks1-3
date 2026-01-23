using UnityEngine;
using UnityEngine.InputSystem;

public class Looker : MonoBehaviour
{
    public float rotationSpeed;
    public float zMax = 10;
    public float zMin = -10;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ROTATING IN A DIRECTION AND SAWPING
        ////If we wanted to move the object, we would use transform.position
        //Vector3 currentRotation = transform.eulerAngles;
        //currentRotation.z += rotationSpeed * Time.deltaTime;

        //transform.eulerAngles = currentRotation;

        //if (transform.eulerAngles.z > zMin)
        //{
        //    rotationSpeed *= -1f;
        //}
        //if (transform.eulerAngles.z < zMax)
        //{
        //    rotationSpeed *= -1f;
        //}
        //Debug.Log("Hi");

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        // I could use Vector2 for this value but, using Vector3 and set the z position as a zero will be more clear.
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        //Setting the direction we're looking in to get the direction we do END - START
        transform.up = worldMousePosition - transform.position;

        transform.position += transform.up * 1f * Time.deltaTime;

    }
}
