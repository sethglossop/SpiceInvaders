using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapShoot : MonoBehaviour
{
    public float range;
    public float shootfreq;
    public GameObject flash;
    private float shoottimer = 0;
    private bool playerSpawned = false;
    private GameObject player;
    private SpriteRenderer render;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (!playerSpawned)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            playerSpawned = true;
        }
        
        shoottimer += Time.deltaTime;
        if (Mathf.Abs(player.transform.position.x - transform.position.x) < range && shoottimer > shootfreq)
        {
            Instantiate(flash, transform.position, Quaternion.identity);
            shoottimer = 0;
        }

        if (player.transform.position.x < transform.position.x)
        {
            render.flipX = true;
        }
        else
        {
            render.flipX = false;
        }
    }
}
