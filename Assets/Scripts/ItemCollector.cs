using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public GameObject player;

    [SerializeField] public int runes;

    [SerializeField] public AudioSource Runesfx;

    [SerializeField] private ParticleSystem Particle1;
    [SerializeField] private ParticleSystem Particle2;
    [SerializeField] private ParticleSystem Particle3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            runes++;

            // Yes this is gross no I'm not gonna fix it
            Particle1.Play();
            Particle2.Play();
            Particle3.Play();
            Runesfx.Play();
        }
    }
}
