using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Jump System")]
    [SerializeField] float jumpTime;
    [SerializeField] public float jumpForce = 10;
    [SerializeField] float fallMultiplier;
    [SerializeField] float jumpMultiplier;

    Rigidbody2D rb;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;
    UnityEngine.Vector2 vecGravity;

    bool isJumping;
    float jumpCounter;

    private float horizontal;
    private float speed = 8f;
    public float maxSpeed = 3f;

    private bool canMove;
     
    // Start is called before the first frame update
    void Start()
    {
        vecGravity = new UnityEngine.Vector2(0, -Physics2D.gravity.y);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        
        isGrounded = Physics2D.OverlapBox(groundCheck.position,new UnityEngine.Vector2(1.0f,.106f), 0,groundLayer);
        //Object.FindAnyObjectByType<AudioManager>().Play("CartRoll");

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //Object.FindAnyObjectByType<AudioManager>().Play("CartJump");
            rb.linearVelocity = new UnityEngine.Vector2(rb.linearVelocity.x, jumpForce);
            isJumping = true;
            jumpCounter = 0;
            transform.eulerAngles = new UnityEngine.Vector3(0, 0, 5);
        }

        if (rb.linearVelocity.y > 0 && isJumping)
        {
            jumpCounter += Time.deltaTime;
            if (jumpCounter > jumpTime) isJumping = false;

            float t = jumpCounter / jumpTime;
            float currentJumpM = jumpMultiplier;

            if (t > 0.5f)
            {
                currentJumpM = jumpMultiplier * (1 - t);
            }

            rb.linearVelocity += vecGravity * currentJumpM * Time.deltaTime;
        }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            jumpCounter = 0;

            if (rb.linearVelocity.y > 0)
            {
                rb.linearVelocity = new UnityEngine.Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.6f);
            }
        }

        if (rb.linearVelocity.y <0)
        {
            rb.linearVelocity -= vecGravity * fallMultiplier * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new UnityEngine.Vector2(horizontal * speed, rb.linearVelocity.y);

        float move = 1.0f;

        GetComponent<Rigidbody2D>().linearVelocity = new UnityEngine.Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().linearVelocity.y);
    }

    public float rotationSpeed = 10f;
    public void LightControl()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
