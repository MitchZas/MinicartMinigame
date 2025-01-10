using UnityEngine;
using UnityEngine.UI;
public class CalculateCoal : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMinCoal(int coal)
    {
        slider.minValue = coal;
        slider.value = coal;

        fill.color = gradient.Evaluate(0f);
    }
    
    public void SetCoal(int coal)
    {
        slider.value = coal;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
