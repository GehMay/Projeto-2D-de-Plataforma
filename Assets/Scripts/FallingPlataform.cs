using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float delay = 1f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic; // fica parada no início
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Invoke("DropPlatform", delay);
        }
    }

    void DropPlatform()
    {
        rb.bodyType = RigidbodyType2D.Dynamic; // ativa a física e a plataforma cai
    }
}
