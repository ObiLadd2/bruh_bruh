
using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   float horizontalinput;
   float moveSpeed = 8f;
    bool isFacingRight;
    float jumpPower = 16f;
    bool isGrounded = false;
  

    Rigidbody2D rb;
    Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isFacingRight = true;
    }

    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");

        FlipSprite();
        if (Input.GetButtonDown("Jump") && isGrounded) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            isGrounded = false;
            animator.SetBool("isJumping", !isGrounded);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalinput * moveSpeed, rb.velocity.y);
        animator.SetFloat("xVelocity", Math.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);
    }
    void FlipSprite()
    {
        if (isFacingRight && horizontalinput < 0f || !isFacingRight && horizontalinput   > 0f)
        {
            print("FLIP Condition");
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
        animator.SetBool("isJumping", !isGrounded);
    }


}










