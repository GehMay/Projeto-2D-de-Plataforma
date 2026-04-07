using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void IniciarJogo()
    {
        // Carrega a primeira fase
        SceneManager.LoadScene("Principal_Hall");
    }

    public void AbrirCreditos()
    {
        // Carrega a cena de créditos
        SceneManager.LoadScene("Créditos");
    }

    public void SairJogo()
    {
        // Fecha o jogo (funciona no build, não no editor)
        Application.Quit();
        Debug.Log("Jogo encerrado!");
    }

    public void VoltarMenu()
    {
        // Volta para o menu principal
        SceneManager.LoadScene("Lobby");
    }
}