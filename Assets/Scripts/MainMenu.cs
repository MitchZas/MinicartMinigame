using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();
   
   public void PlayGame()
   {
        scenesToLoad.Add(SceneManager.LoadSceneAsync("Gameplay"));
        //scenesToLoad.Add(SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Additive));
   }

   public void QuitGame()
   {
        Application.Quit();
   }
}
