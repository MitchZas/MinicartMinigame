using UnityEngine;
using UnityEngine.UI;

public class AnimatedTimerScript : MonoBehaviour
{
    public float timerDuration = 30f;

    public Slider timerSlider;

    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = timerDuration;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        // Animate timer from 1 to 0 
        float normalizedTime = Mathf.Clamp01(timer / timerDuration);

        // Update slider
        timerSlider.value = normalizedTime;

        if (timer <= 0)
        {
            timer = 0;
        }
    }
}
