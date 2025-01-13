using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CalculateLight : MonoBehaviour
{
    public Light2D globalLight;

    private void Start()
    {
        LightAmount();
    }

    public void LightAmount()
    {
        if(CoalScore.totalCoal == 0)
        {
            globalLight.intensity = 0;
        }

        if (CoalScore.totalCoal == 1)
        {
            globalLight.intensity = .15f;
        }

        if (CoalScore.totalCoal == 2)
        {
            globalLight.intensity = .50f;
        }

        if (CoalScore.totalCoal == 3)
        {
            globalLight.intensity = .75f;
        }

        if (CoalScore.totalCoal == 4)
        {
            globalLight.intensity = 1;
        }
    }
}
