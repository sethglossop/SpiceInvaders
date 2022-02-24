using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSporty : MonoBehaviour
{
    public float jumpboost;
    private float originaljump;
    private float newjump;
    private LevelMaster levelmaster;
    private PlayerMove movement;

    void Start()
    {
        levelmaster = FindObjectOfType<LevelMaster>();
        movement = GetComponent<PlayerMove>();
        originaljump = movement.jumpspeed;
        newjump = movement.jumpspeed + jumpboost;
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && levelmaster.playerCurrentPower > 0)
        {
            levelmaster.playerCurrentPower -= Time.deltaTime;
            movement.jumpspeed = newjump;
        }
        else
        {
            movement.jumpspeed = originaljump;
        }
    }
}
