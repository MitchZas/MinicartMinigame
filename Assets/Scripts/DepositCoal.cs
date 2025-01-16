using System.Collections;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class DepositCoal : MonoBehaviour
{
    public Canvas coalDepositCanvas;
    public GameObject cartCoal;
    public GameObject collectCoal;

    public Canvas NextLevelCanvas;

    public int minCoal = 0;
    public int currentCoal;
    public int coalDeposited;

    public CalculateCoal calculateCoal;

    public Light2D globalLight;

    private bool triggerEntered = false;
    private DestroyCoal destroyCoalscript;

    public int currentLevel = 0;

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
                Object.FindAnyObjectByType<AudioManager>().Play("CoalDeposit");
                CoalDeposit(); 
            }

        if (Input.GetKeyDown(KeyCode.E) && triggerEntered == true && currentLevel == 3)
        {
           StartCoroutine(LastLevel());
;       }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(CartTrigger());
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
                CoalScore.totalCoal = 0;
                //globalLight.intensity = 0;
                Debug.Log("No Coal was deposited");
            }
            // If there is one coal object active, set the value to 1
            if (DestroyCoal.coalNumber == 1)
            {
                calculateCoal.SetCoal(1);
                CoalScore.totalCoal = 1;
                //globalLight.intensity = .15f;
                Debug.Log("One Coal was deposited");
            }
            // If there are two coal objects active, set the value to 2
            if (DestroyCoal.coalNumber == 2)
            {
                calculateCoal.SetCoal(2);
                CoalScore.totalCoal = 2;
                //globalLight.intensity = .50f;
                Debug.Log("Two Coal were deposited");
            }
            // If there are three coal objects active, set the value to 3
            if (DestroyCoal.coalNumber == 3)
            {
                calculateCoal.SetCoal(3);
                CoalScore.totalCoal = 3;
                //globalLight.intensity = 0.75f;
                Debug.Log("Three Coal were deposited");
            }
            // If there are four coal objects active, set the value to 4
            if (DestroyCoal.coalNumber == 4)
            {
                calculateCoal.SetCoal(4);
                CoalScore.totalCoal = 4;
                //globalLight.intensity = 1;
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

    IEnumerator CartTrigger()
    {
        triggerEntered = true;
        yield return new WaitForSeconds(1);
        coalDepositCanvas.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        NextLevelCanvas.gameObject.SetActive(true);
    }

    IEnumerator LastLevel()
    {
        CartEnter();
        Object.FindAnyObjectByType<AudioManager>().Play("CoalDeposit");
        CoalDeposit();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(9);
    }
}
