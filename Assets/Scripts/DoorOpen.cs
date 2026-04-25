using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    bool doorOpen = false;
    [SerializeField] private ParticleSystem doorParticle;

    [SerializeField] private int runes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorOpen)
            transform.position = new Vector2(transform.position.x, transform.position.y - .01f);
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            runes = other.gameObject.GetComponent<ItemCollector>().runes;
            Debug.Log(runes);
            if(runes >= 3)
            {
                doorParticle.Play();
                doorOpen = true;
                //add sound effect here
                //And timer into scene switch
            }
        }
    }
}
