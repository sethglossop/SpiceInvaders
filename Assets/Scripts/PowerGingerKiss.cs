using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerGingerKiss : MonoBehaviour
{
    public float kissspeed;
    public float range;
    private GameObject player;
    private Rigidbody2D rb;
    private SpriteRenderer render;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        render = player.GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        if (render.flipX)
        {
           kissspeed = -kissspeed;
            render.flipX = true;
        }
    }

    void Update()
    {
        rb.velocity = new Vector2(kissspeed, rb.velocity.y);

        if (Mathf.Abs(player.transform.position.x - transform.position.x) > range) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
