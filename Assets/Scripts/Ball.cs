using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 0.02f;
    public float xMax;
    public float xMin;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Ball = transform.position;
        Ball.x += speed * Time.deltaTime;

        transform.position = Ball;

        //Screen.width;
        //gameCamera.WorldToScreenPoint(//somerandomvector);

        //set xMax to wherever is too far to the right for the player to see
        Vector3 screen = gameCamera.WorldToScreenPoint(transform.position);
        xMax = Screen.width;

        //set xMin to wherever is too far to the left for the player to see
        xMin = 0;


        if (xMax < screen.x)
        {
            speed *= -1;
        }

        if (xMin > screen.x)
        {
            speed *= -1;
        }

    }
}
