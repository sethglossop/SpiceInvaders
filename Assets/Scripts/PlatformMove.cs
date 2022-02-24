using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{

    public bool horizontal;
    public float distance;
    public float speed;
    private Rigidbody2D rb;
    private float vertstartpos;
    private float horistartpos;
    private float move = 1;

    void Start()
    {
        horistartpos = transform.position.x;
        vertstartpos = transform.position.y;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (horizontal)
        {
            rb.velocity = new Vector2(move * speed, 0);

            if (Mathf.Abs(transform.position.x - horistartpos) > distance)
            {
                move = -move;
                horistartpos = transform.position.x;
            }
        }
        else
        {
            rb.velocity = new Vector2(0, move * speed);
            if (Mathf.Abs(transform.position.y - vertstartpos) > distance)
            {
                move = -move;
                vertstartpos = transform.position.y;
            }
        }
    }
}
 