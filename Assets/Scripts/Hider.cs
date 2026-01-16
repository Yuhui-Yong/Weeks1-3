using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Hider : MonoBehaviour
{
    public Vector3 hidePosition;
    public float hideDistance;
    public Camera gameCamera;

    public float waitDuration;

    private float timePassed = 0f;
    public float timeSinceLastFrame = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 currenMousePosition = Mouse.current.position.ReadValue();
        //Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currenMousePosition);
        //worldMousePosition.z = 0f;

        //float distanceToMouse = Vector3.Distance(worldMousePosition, transform.position);

        //if(distanceToMouse < hideDistance)
        //{
        //    transform.position = hidePosition * Time.deltaTime;
        timeSinceLastFrame = Time.deltaTime;
        timePassed += Time.deltaTime;
    if(timePassed > waitDuration)
    {
        transform.position = hidePosition;
    }
}
}