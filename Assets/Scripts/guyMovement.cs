using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guyMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 5f;

    Rigidbody2D rb;
    [SerializeField] int jumpPower;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;

    public bool canMove;
    
    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
        canMove = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            horizontal = Input.GetAxis("Horizontal");
        }
        
        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(.072f, 1f),CapsuleDirection2D.Horizontal, 0, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded && canMove)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

}
