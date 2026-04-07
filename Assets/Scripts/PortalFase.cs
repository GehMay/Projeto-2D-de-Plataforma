using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalFase : MonoBehaviour
{
    public string nomeDaCena; // Defina no Inspector
    private bool playerDentro = false;

    void Update()
    {
        if (playerDentro && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(nomeDaCena);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerDentro = true;
            Debug.Log("Pressione E para entrar na fase!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerDentro = false;
        }
    }
}