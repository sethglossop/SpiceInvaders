using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerGinger : MonoBehaviour
{
    public float shootfreq;
    public GameObject kiss;
    private float shoottimer;
    
    private LevelMaster levelmaster;

    void Start()
    {
        levelmaster = FindObjectOfType<LevelMaster>();
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && levelmaster.playerCurrentPower > 0)
        {
            levelmaster.playerCurrentPower -= Time.deltaTime;

            shoottimer -= Time.deltaTime;
            if (shoottimer < 0)
            {
                Instantiate(kiss, transform.position, Quaternion.identity);
                shoottimer = shootfreq;
            }
        }
        else
        {
            shoottimer = 0;
        }
    }
}
