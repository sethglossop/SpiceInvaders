using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Slider slider;
    private LevelMaster levelmaster;

    void Start()
    {
        slider = GetComponent<Slider>();
        levelmaster = FindObjectOfType<LevelMaster>();
        slider.maxValue = levelmaster.playerMaxHealth;
        slider.value = levelmaster.playerMaxHealth;
    }

    void Update()
    {
        {
            slider.value = levelmaster.playerCurrentHealth;
        }
    }
}
