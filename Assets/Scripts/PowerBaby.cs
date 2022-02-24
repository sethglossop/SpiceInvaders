using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBaby : MonoBehaviour
{
    public float healthrate;
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
            levelmaster.playerCurrentHealth += Time.deltaTime * healthrate;
        }
    }
}
