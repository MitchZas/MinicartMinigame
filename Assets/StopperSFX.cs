using UnityEngine;

public class StopperSFX : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Object.FindAnyObjectByType<AudioManager>().Play("CartStopper");
        }
    }
}

