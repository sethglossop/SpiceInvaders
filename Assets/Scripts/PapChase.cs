using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapChase : MonoBehaviour
{
    public float wallspeed = 3;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(wallspeed,0);
    }
}
