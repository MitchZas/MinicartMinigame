using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
   List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();

    //public Button button;
    public Vector3 pressedScale = new Vector3(0.9f, 0.9f, 1f);

    private void Start()
    {
        //button = GetComponent<Button>();
        //button.onClick.AddListener(HandleClick);
    }

    public void PlayGame()
   {
        scenesToLoad.Add(SceneManager.LoadSceneAsync("Gameplay"));
        //scenesToLoad.Add(SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Additive));
   }

   public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    
    public void QuitGame()
   {
        Application.Quit();
   }
}
