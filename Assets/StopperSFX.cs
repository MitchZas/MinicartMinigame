using UnityEngine;

public class StopperSFX : MonoBehaviour
{
   public AudioSource cartRollSFX;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Object.FindAnyObjectByType<AudioManager>().Play("CartStopper");
            cartRollSFX.Stop();
        }
    }
}

