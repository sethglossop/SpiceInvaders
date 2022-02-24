using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerScary : MonoBehaviour
{
    public float runboost;
    private float originalrun;
    private float newrun;
    private LevelMaster levelmaster;
    private PlayerMove movement;

    void Start()
    {
        levelmaster = FindObjectOfType<LevelMaster>();
        movement = GetComponent<PlayerMove>();
        originalrun = movement.runspeed;
        newrun = movement.runspeed + runboost;
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && levelmaster.playerCurrentPower > 0)
        {
            levelmaster.playerCurrentPower -= Time.deltaTime;
            movement.runspeed = newrun;
        }
        else
        {
            movement.runspeed = originalrun;
        }
    }
}
