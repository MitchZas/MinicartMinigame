using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
   List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();

    //public Button button;
    public Vector3 pressedScale = new Vector3(0.9f, 0.9f, 1f);

    [SerializeField] AudioSource buttonClickAudio;

    private void Start()
    {
        //button = GetComponent<Button>();
        //button.onClick.AddListener(HandleClick);
    }

    public void PlayGame()
   {
        buttonClickAudio.Play();
        scenesToLoad.Add(SceneManager.LoadSceneAsync("Gameplay"));
   }

   public void Tutorial()
    {
        buttonClickAudio.Play();
        SceneManager.LoadScene("TutorialText");
    }
    
    public void QuitGame()
   {
        buttonClickAudio.Play();
        Application.Quit();
   }
}
