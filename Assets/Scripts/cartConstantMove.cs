using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartConstantMove : MonoBehaviour
{
    gameManager GameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameManager = gameController.GetComponent<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(GameManager.moveVector * GameManager.moveSpeed * Time.deltaTime);
    }
}
