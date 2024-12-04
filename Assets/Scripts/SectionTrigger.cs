using UnityEngine;
using TMPro;

public class SectionTrigger : MonoBehaviour
{
    public GameObject newSection;

    public Canvas coalDepositCanvas;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(newSection, new Vector3(108,-4, 9), Quaternion.identity);
        }

        if (other.gameObject.CompareTag("Furnance"))
        {
            coalDepositCanvas.gameObject.SetActive(true);
        }
    }

    
        

       // If E prompt is pushed
       // Set Active False all the tags with CoalCart that are active
}
