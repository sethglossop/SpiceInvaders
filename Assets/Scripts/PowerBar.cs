using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    private Slider slider;
    private LevelMaster levelmaster;

    void Start()
    {
        slider = GetComponent<Slider>();
        levelmaster = FindObjectOfType<LevelMaster>();
        slider.maxValue = levelmaster.playerMaxPower;
        slider.value = 0;
    }

    void Update()
    {
        slider.value = levelmaster.playerCurrentPower;
    }
}
