using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapFlash : MonoBehaviour
{
    public float flashspeed;
    public float range;
    private GameObject player;
    private Rigidbody2D rb;
    private SpriteRenderer render;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();

        if (player.transform.position.x < transform.position.x)
        {
            flashspeed = -flashspeed;
            render.flipX = true;
        }
    }

    void Update()
    {
        rb.velocity = new Vector2(flashspeed, rb.velocity.y);
        if (Mathf.Abs(player.transform.position.x - transform.position.x) > range) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
