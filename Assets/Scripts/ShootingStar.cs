using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    public Vector2 startPos = new Vector2(-3.14f, 5.36f); // This starts at off the screen.
    public Vector2 endPos = new Vector2(3.42f, -1.79f); // This ends at off the screen.
    public float t = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime; // run the timer for t: make t get bigger.
        if(t > 1)
        {
            t = 0; // check if t has reached the max value I want.
        }
        transform.position = Vector2.Lerp(startPos, endPos, t); // Vector2.Lerp, setting it with StartPos, endPos, and t variables.
    }
}