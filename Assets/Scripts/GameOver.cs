using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{   
   public Animator animator;

   public Canvas gameOverCanvas;
   public Rigidbody2D playerRB;
   public TextMeshProUGUI scoreText;
   
   private float distance;
   
   private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(LevelReset());
        }    
    }

    IEnumerator LevelReset()
    {
        FindObjectOfType<AudioManager>().Play("GameOver");
        yield return new WaitForSeconds(1);
        playerRB.constraints = RigidbodyConstraints2D.FreezeAll;
        gameOverCanvas.gameObject.SetActive(true);
        distance = playerRB.transform.position.x;
        scoreText.text = distance.ToString("F1") + " M Traveled";
    }

    public void MainMenu()
   {
        SceneManager.LoadScene(0);
   }

   public void RestartGame()
   {
        SceneManager.LoadScene(1);
   }
}
