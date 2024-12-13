using UnityEngine;
using UnityEngine.UI;
public class CalculateCoal : MonoBehaviour
{
    public Slider slider;

    public void SetMaxCoal(int coal)
    {
        slider.minValue = coal;
        slider.value = coal;
    }
    
    public void SetCoal(int coal)
    {
        slider.value = coal;
    }
}
