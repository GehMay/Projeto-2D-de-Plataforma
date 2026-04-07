using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform jogador;
    public float velocityCamera = 5f;

    public float offsetX = 0f;
    public float limiteMinX = -12.5f;
    public float limiteMaxX = 9999f;

    // Update is called once per frame
    void LateUpdate()
    {
        //Posição X da câmera segue o jogador, mas com limites para não ultrapassar as bordas do cenário
        float posX = jogador.position.x + offsetX;

        //Limite entre o Mínimo e Máximo da posição X
        posX = Mathf.Clamp(posX, limiteMinX, limiteMaxX);

        //Aplica na câmera a posição calculada, mantendo a posição Y
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}