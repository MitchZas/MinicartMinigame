using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip buttonClick;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

}
