using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public static string charchoose;

    public void PlayGame()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void ChooseScary()
    {
        charchoose = "Scary";
    }
    public void ChooseBaby()
    {
        charchoose = "Baby";
    }
    public void ChooseGinger()
    {
        charchoose = "Ginger";
    }
    public void ChoosePosh()
    {
        charchoose = "Posh";
    }
    public void ChooseSporty()
    {
        charchoose = "Sporty";
    }
}
