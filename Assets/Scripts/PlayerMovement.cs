using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Jump System")]
    [SerializeField] float jumpTime;
    [SerializeField] float jumpForce = 10;
    [SerializeField] float fallMultiplier;
    [SerializeField] float jumpMultiplier;

    Rigidbody2D rb;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;
    UnityEngine.Vector2 vecGravity;

    bool isJumping;
    float jumpCounter;

    //public bool freezeRotation;

    private float horizontal;
    private float speed = 4f;
    public float maxSpeed = 3f;
     
    // Start is called before the first frame update
    void Start()
    {
        vecGravity = new UnityEngine.Vector2(0, -Physics2D.gravity.y);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal = Input.GetAxis("Horizontal");
        
        isGrounded = Physics2D.OverlapBox(groundCheck.position,new UnityEngine.Vector2(1.0f,.106f), 0,groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new UnityEngine.Vector2(rb.velocity.x, jumpForce);
            isJumping = true;
            jumpCounter = 0;

            rb.freezeRotation = true;
        }

        if (rb.velocity.y > 0 && isJumping)
        {
            jumpCounter += Time.deltaTime;
            if (jumpCounter > jumpTime) isJumping = false;

            float t = jumpCounter / jumpTime;
            float currentJumpM = jumpMultiplier;

            if (t > 0.5f)
            {
                currentJumpM = jumpMultiplier * (1 - t);
            }

            rb.velocity += vecGravity * currentJumpM * Time.deltaTime;
        }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            jumpCounter = 0;
            rb.freezeRotation = false;

            if (rb.velocity.y > 0)
            {
                rb.velocity = new UnityEngine.Vector2(rb.velocity.x, rb.velocity.y * 0.6f);
            }
        }

        if (rb.velocity.y <0)
        {
            rb.velocity -= vecGravity * fallMultiplier * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new UnityEngine.Vector2(horizontal * speed, rb.velocity.y);

        float move = 1.0f;

        GetComponent<Rigidbody2D>().velocity = new UnityEngine.Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }
}
