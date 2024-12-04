using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject coalAppear;
    public GameObject coalDisappear;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            coalDisappear.SetActive(false);
            coalAppear.SetActive(true);
        }
    }
}
