using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    [SerializeField] AudioSource buttonClickAudio;
    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
        buttonClickAudio.Play();
    }
}
