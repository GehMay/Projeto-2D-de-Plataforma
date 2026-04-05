using UnityEngine;

public class RotatingPlataform : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            // gira continuamente depois de ativada
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            // ativa o giro quando o player encosta
            isRotating = true;
        }
    }

    // opcional: resetar para estado inicial
    public void ResetPlataform()
    {
        isRotating = false;
        transform.rotation = Quaternion.identity;
    }
}