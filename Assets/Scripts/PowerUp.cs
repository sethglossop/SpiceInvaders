using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public LevelMaster levelmaster;
    public AudioSource powersound;

    void Start()
    {
        levelmaster = FindObjectOfType<LevelMaster>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Powerup")) {
            powersound.Play();
            levelmaster.playerCurrentPower++;
            Destroy(other.gameObject);
        }
    }
}
