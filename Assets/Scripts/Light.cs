using UnityEngine;

public class Light : MonoBehaviour
{
    public AnimationCurve cureve; // Make an animation curve. Make it public, so I can adjust.
    public float duration; // This is for duration.
    public float output; // This is for output.

    private float progress = 0f; // Set progress as 0.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime / duration;
        output = cureve.Evaluate(progress);

        transform.localScale = Vector3.one * output;

        if (progress > 1f)
        {
            progress = 0f;
        }
    }
}
