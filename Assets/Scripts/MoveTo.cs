using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public GameObject Cart;
    public GameObject End;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cart.transform.position = UnityEngine.Vector2.MoveTowards(Cart.transform.position, End.transform.position, speed);
    }
}
