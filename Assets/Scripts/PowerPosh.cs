using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPosh : MonoBehaviour
{
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
            levelmaster.invincible = true;
        }
        else
        {
            levelmaster.invincible = false;
        }
    }
}
