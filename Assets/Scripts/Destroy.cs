using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject coalAppear;
    public GameObject coalDisappear;
    public GameObject cart;

    private PlayerMovement playerMovementScript;

    private void Start()
    {
        playerMovementScript = cart.GetComponent<PlayerMovement>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AddCoal();
        }
    }

    public void AddCoal()
    {
        coalDisappear.SetActive(false);
        coalAppear.SetActive(true);
        playerMovementScript.jumpForce -= 2;
    }
}
