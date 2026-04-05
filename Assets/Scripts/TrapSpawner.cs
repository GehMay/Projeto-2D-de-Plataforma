using UnityEngine;

public class TrapSpawner : MonoBehaviour
{
    public GameObject[] armadilhas;       // Arraste seus prefabs aqui
    public Transform[] pontosDeSpawn;     // Pontos onde podem aparecer
    public float tempoMinimo = 1f;
    public float tempoMaximo = 4f;

    void Start()
    {
        // Começa a spawnar
        Invocar();
    }

    void Invocar()
    {
        // Tempo aleatório entre os spawns
        float tempoEspera = Random.Range(tempoMinimo, tempoMaximo);
        Invoke("SpawnarArmadilha", tempoEspera);
    }

    void SpawnarArmadilha()
    {
        // Escolhe armadilha e ponto aleatórios
        int indexArmadilha = Random.Range(0, armadilhas.Length);
        int indexPonto = Random.Range(0, pontosDeSpawn.Length);

        Instantiate(
            armadilhas[indexArmadilha],
            pontosDeSpawn[indexPonto].position,
            Quaternion.identity
        );

        Invocar(); // Chama a próxima
    }
}