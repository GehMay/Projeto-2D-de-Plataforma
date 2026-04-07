using UnityEngine;
using UnityEngine.SceneManagement;

public class Respaw : MonoBehaviour
{
    public float limiteY = -15f; // Limite de queda para respawn
    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position; // Armazena a posição inicial do jogador
    }

    void Update()
    {
        if (transform.position.y < limiteY)
        {
            RespawnPlayer();
        }
    }

    void RespawnPlayer()
    {
        transform.position = posicaoInicial; // Move o jogador de volta para a posição inicial
        // Opcional: Reiniciar a cena para resetar o estado do jogo
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}