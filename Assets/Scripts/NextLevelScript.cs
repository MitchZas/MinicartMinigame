using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    [SerializeField] AudioSource buttonClickAudio;
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        buttonClickAudio.Play();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
