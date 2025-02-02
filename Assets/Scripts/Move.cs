using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    public float deadZone = -3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
