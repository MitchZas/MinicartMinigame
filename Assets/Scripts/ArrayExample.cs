using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // Example 01
    int[] numberArray = new int[4];

    // Example 02
    string[] names = {"Coal1", "Coal2", "Coal3", "Coal4" };

    // Example 03
    public GameObject[] coalPieces;
    void Start()
    {
        numberArray[0] = 1;
        numberArray[1] = 2;
        numberArray[2] = 3;
        numberArray[3] = 4;

        
    }

    // Update is called once per frame
    void Update()
    {
        coalPieces = GameObject.FindGameObjectsWithTag("CartCoal");
    }
}
