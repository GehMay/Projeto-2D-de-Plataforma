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
        SceneManager.LoadScene("Creditos");
    }

    public void SairJogo()
    {
        // Fecha o jogo (funciona no build, não no editor)
        Application.Quit();
        Debug.Log("Jogo encerrado!");
    }
}