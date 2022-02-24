using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyline : MonoBehaviour
{
    public float moverate;
    public GameObject camerapos;
    private float distance;
    private float startpos;

    void Start()
    {
        startpos = transform.position.x;
    }

    void Update()
    {
        distance = (camerapos.transform.position.x * moverate);
        transform.position = new Vector2(startpos + distance, transform.position.y);
    }
}
