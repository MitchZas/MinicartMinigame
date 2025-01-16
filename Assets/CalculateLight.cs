using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CalculateLight : MonoBehaviour
{
    public Light2D globalLight;

    public Light2D spotLight;

    private void Start()
    {
        spotLight.gameObject.SetActive(false);
        LightAmount();
    }

    public void LightAmount()
    {
        if(CoalScore.totalCoal == 0)
        {
            globalLight.intensity = 0.01f;
            spotLight.gameObject.SetActive(true);
        }

        if (CoalScore.totalCoal == 1)
        {
            globalLight.intensity = .01f;
            spotLight.gameObject.SetActive(true);
        }

        if (CoalScore.totalCoal == 2)
        {
            globalLight.intensity = .2f;
            spotLight.gameObject.SetActive(true);
        }

        if (CoalScore.totalCoal == 3)
        {
            globalLight.intensity = .3f;
            spotLight.gameObject.SetActive(true);
        }

        if (CoalScore.totalCoal == 4)
        {
            globalLight.intensity = 1;
        }
    }
}
