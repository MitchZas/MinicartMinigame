using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoal : MonoBehaviour
{
    public GameObject coalAppear;
    public GameObject coalDisappear;
    public GameObject cart;

    public static int coalNumber;

    private PlayerMovement playerMovementScript;

    public bool destroyScript = false;

    void Start()
    {
        playerMovementScript = cart.GetComponent<PlayerMovement>();
        coalNumber = 0;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            AddCoal(); 
        }
    }

    public void AddCoal()
    {
        Debug.Log(coalNumber += 1);
        Object.FindAnyObjectByType<AudioManager>().Play("CoalCollect");
        //coalDisappear.SetActive(false);
        coalAppear.SetActive(true);
        playerMovementScript.jumpForce -= 2;
    }
}
