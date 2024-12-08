using UnityEngine;

public class DepositCoal : MonoBehaviour
{
    public Canvas coalDepositCanvas;
    public GameObject cartCoal;

    private bool triggerEntered = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggerEntered == true)
            {
            CoalDeposit();
            }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            triggerEntered = true;
            coalDepositCanvas.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        triggerEntered = false;
    }

    void CoalDeposit()
    {
        triggerEntered = true;

        if (Input.GetKeyDown(KeyCode.E))
        {
            coalDepositCanvas.gameObject.SetActive(false);
            Debug.Log("Coal was deposited");
            cartCoal.gameObject.SetActive(false);
        }
    }
}
