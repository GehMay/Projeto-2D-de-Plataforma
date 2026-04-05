using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    public Transform pontoInicial;    // arraste o Empty que marca o início
    public Transform player;          // arraste o Player aqui
    public float distanciaAtivacao = 5f; // raio de ativação
    public float delayQueda = 1f;        // tempo de espera antes de cair

    private Rigidbody2D rb;
    private Vector3 posicaoOriginal;
    private bool ativada = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic; // começa travado, não cai sozinho
        posicaoOriginal = transform.position; // guarda posição inicial
    }

    void Update()
    {
        // só ativa se o Player estiver perto
        if (!ativada && Vector2.Distance(transform.position, player.position) < distanciaAtivacao)
        {
            Invoke("AtivarQueda", delayQueda);
            ativada = true;
        }
    }

    void AtivarQueda()
    {
        rb.bodyType = RigidbodyType2D.Dynamic; // libera a física e os espinhos caem
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // teleporta o Player para o início
            collision.transform.position = pontoInicial.position;

            // zera velocidade para não sair voando
            Rigidbody2D rbPlayer = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rbPlayer != null) rbPlayer.linearVelocity = Vector2.zero;
        }
    }
}