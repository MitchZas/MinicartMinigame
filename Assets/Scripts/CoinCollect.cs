using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
 private void OnTriggerEnter2D(Collider2D collision) 
 {
    if (collision.gameObject.CompareTag("Player"))
    {
        Debug.Log("Coin collected!");
        Destroy(gameObject);
    }    
 }
}
