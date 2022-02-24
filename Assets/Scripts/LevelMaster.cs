using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMaster : MonoBehaviour
{
    public float playerMaxHealth;
    public float playerCurrentHealth;
    public float playerMaxPower;
    public float playerCurrentPower = 0;
    public bool invincible = false;

    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }

    void Update()
    {
        if (playerCurrentHealth == 0)
        {
            Death();
        }
    }

    public void Hurt()
    {
        if(!invincible)
        {
            playerCurrentHealth--;
        }
    }

    public void Death()
    {
        SceneManager.LoadScene("MainLevel");
    }
}
