using UnityEngine;
using TMPro;

public class SectionTrigger : MonoBehaviour
{
    public GameObject newSection;

    //public Canvas coalDepositCanvas;

    public GameObject cartCoal;

    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.gameObject.CompareTag("Button"))
        {
           // coalDepositCanvas.gameObject.SetActive(true);
            DepositCoal();
        }

        void DepositCoal()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //coalDepositCanvas.gameObject.SetActive(false);
                Debug.Log("Coal was deposited");
                //cartCoal.gameObject.SetActive(false);
            }
        }
    }

    
        

       // If E prompt is pushed
       // Set Active False all the tags with CoalCart that are active
}
