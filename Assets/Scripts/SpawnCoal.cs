using UnityEngine;

public class SpawnCoal : MonoBehaviour
{
    public GameObject coalAppear1;

    void Update()
    {
        if (!GameObject.FindWithTag("CoalD"))
        {
            coalAppear1.SetActive(true);
        }
    }
}
