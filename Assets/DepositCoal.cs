using TMPro.Examples;
using UnityEngine;

public class DepositCoal : MonoBehaviour
{
    public Canvas coalDepositCanvas;
    public GameObject cartCoal;

    public int minCoal = 0;
    public int currentCoal;

    private bool triggerEntered = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggerEntered == true)
            {
                CartEnter();
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
        {
            // If there is one coal object active, set the value to 1
            // If there are two coal objects active, set the value to 2
            // If there are three coal objects active, set the value to 3
            // If there are four coal objects active, set the value to 4
        }
    }

    void CartEnter()
    {
        triggerEntered = true;
        coalDepositCanvas.gameObject.SetActive(false);
        cartCoal.gameObject.SetActive(false);
    }
}
