using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 0.02f;
    public float xMax;
    public float xMin;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        moverXPos.x = moverXPos.x + speed;
        transform.position = moverXPos;

        if (xMax < transform.position.x)
        {
            speed *= -1;
        }
        if (xMin > transform.position.x)
        {
            speed *= -1;
        }
    }
}
