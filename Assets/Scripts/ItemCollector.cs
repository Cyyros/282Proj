using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public GameObject player;

    [SerializeField]
    public int runes;

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
        }
    }
}
