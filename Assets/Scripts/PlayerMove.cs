using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runspeed;
    public float jumpspeed;
    public AudioSource jumpsound;
    private float move = 0;
    private bool jumping = false;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer render;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * runspeed, rb.velocity.y);
        
        if (Input.GetButtonDown("Jump") && jumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpspeed));
            jumpsound.Play();
            jumping = true;
        }

        RunAnimations();
    }

     private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Platform"))
        {
            jumping = false;
        }
    }

    void RunAnimations()
    {
        anim.SetBool("Running", move != 0);
        anim.SetBool("Jumping", jumping);
        if (move < 0)
        {
            render.flipX = true;
        }
        else if (move > 0)
        {
            render.flipX = false;
        }
    }
}
