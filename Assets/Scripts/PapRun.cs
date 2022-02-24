using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapRun : MonoBehaviour
{
    public float runspeed;
    public float rundistance;
    private float startpos;
    private float move = 1;
    private Rigidbody2D rb;
    private SpriteRenderer render;

    void Start()
    {
        startpos = transform.position.x;
        rb = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        rb.velocity = new Vector2(move * runspeed, 0);

        if (Mathf.Abs(transform.position.x - startpos) > rundistance)
        {
            move = -move;
            startpos = transform.position.x;
        }

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
