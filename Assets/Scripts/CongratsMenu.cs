using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CongratsMenu : MonoBehaviour
{
    private GameObject music;

    private void Start()
    {
        music = GameObject.FindGameObjectWithTag("Music");
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Destroy(music);
            SceneManager.LoadScene("Menu");
        }
    }
}
