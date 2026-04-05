using UnityEngine;

public class TrapActivator : MonoBehaviour
{
    public GameObject trap;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            trap.SetActive(true);
        }
    }
}