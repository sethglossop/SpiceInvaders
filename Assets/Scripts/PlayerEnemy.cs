using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemy : MonoBehaviour
{
    public LevelMaster levelmaster;
    public float repelforce;
    public float knocktime;
    public AudioSource hurtsound;
    private bool knockback = false;
    private float knockcounter = 0;
    private Rigidbody2D rb;
    private Vector2 direction;

    void Start()
    {
        levelmaster = FindObjectOfType<LevelMaster>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (knockback)
        {
            knockcounter += Time.deltaTime;
            if (knockcounter > knocktime)
            {
                knockback = false;
                knockcounter = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (transform.position.x < other.transform.position.x)
            {
                direction = new Vector2(-1, 0);
            }
            else
            {
                direction = new Vector2(1, 0);
            }
            rb.AddForce(direction*repelforce);
            hurtsound.Play();
            if (!knockback)
            {
                levelmaster.Hurt();
                knockback = true;
            }
        }
        else if (other.gameObject.CompareTag("Death"))
        {
            levelmaster.Death();
        }
        else if (other.gameObject.CompareTag("Bullet"))
        {
            hurtsound.Play();
            levelmaster.Hurt();
        }
    }
}
