using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public GameObject newSection;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(newSection, new Vector3(108,-4, 9), Quaternion.identity);
        }
    }
}
