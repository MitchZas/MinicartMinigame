using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI distanceText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        distanceText.text = score.ToString() + " M TRAVELED";
    }
}
