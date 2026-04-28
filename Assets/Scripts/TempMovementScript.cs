using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement Speed")]
    [SerializeField]
    private float speed;

    [SerializeField] public AudioSource Jumpsfx;

    // Update is called once per frame
    void Update()
    {
        HandleUserInput();

        if (Input.GetKeyDown(KeyCode.W))
            Jumpsfx.Play();
    }

    void HandleUserInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        }
    }
}
