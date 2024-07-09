using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{   
   public Animator animator;
   
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
        FadeToLevel(1);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void FadeToLevel (int levelIndex)
    {
        animator.SetTrigger("FadeOut");
    }
}
