using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DistanceScoreScript : MonoBehaviour
{
    public GameObject startPos;
    public GameObject scoreTextObj;
    public TextMeshProUGUI scoreText;

    private float distance;

    void Start() 
    {
        scoreText = scoreTextObj.GetComponent<TextMeshProUGUI>();
    }

    void Update() 
    {
        distance = (startPos.transform.position.x + this.transform.position.x);
        scoreText.text = distance.ToString("F1") + "M";
    }
    
}
