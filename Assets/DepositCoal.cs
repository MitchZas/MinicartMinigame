using TMPro.Examples;
using UnityEngine;

public class DepositCoal : MonoBehaviour
{
    public Canvas coalDepositCanvas;
    public GameObject cartCoal;
    public GameObject collectCoal;

    public int minCoal = 0;
    public int currentCoal;
    public int coalDeposited;

    public CalculateCoal calculateCoal;

    private bool triggerEntered = false;
    private DestroyCoal destroyCoalscript;

    void Start()
    {
        destroyCoalscript = collectCoal.GetComponent<DestroyCoal>();
        calculateCoal.SetMinCoal(minCoal);
    }

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
            // If there are zero coal objects active, set the value to 0
            if (DestroyCoal.coalNumber == 0)
            {
                calculateCoal.SetCoal(0);
                Debug.Log("No Coal was deposited");
            }
            // If there is one coal object active, set the value to 1
            if (DestroyCoal.coalNumber == 1)
            {
                calculateCoal.SetCoal(1);
                Debug.Log("One Coal was deposited");
            }
            // If there are two coal objects active, set the value to 2
            if (DestroyCoal.coalNumber == 2)
            {
                calculateCoal.SetCoal(2);
                Debug.Log("Two Coal were deposited");
            }
            // If there are three coal objects active, set the value to 3
            if (DestroyCoal.coalNumber == 3)
            {
                calculateCoal.SetCoal(3);
                Debug.Log("Three Coal were deposited");
            }
            // If there are four coal objects active, set the value to 4
            if (DestroyCoal.coalNumber == 4)
            {
                calculateCoal.SetCoal(4);
                Debug.Log("Four Coal were deposited");
            }
        }
    }

    void CartEnter()
    {
        triggerEntered = true;
        coalDepositCanvas.gameObject.SetActive(false);
        cartCoal.gameObject.SetActive(false);
    }
}
