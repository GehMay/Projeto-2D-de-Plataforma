using UnityEngine;

public class PlayerHallMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Captura do input horizontal (A/D ou setas)
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        // Movimento apenas horizontal
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);
    }
}