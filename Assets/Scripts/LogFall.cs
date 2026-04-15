using UnityEngine;

public class LogFall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Causes the log to fall
        transform.position += new Vector3(0, -.9f, 0) * Time.deltaTime;

        // Checks the lower bound and sends log back to upper bound
        if (transform.position.y < -5.75)
            transform.position = new Vector3(0, 1.75f, 0);
    }
}
