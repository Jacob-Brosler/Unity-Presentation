﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        transform.Translate(new Vector3(0, 0, -10));
    }

    public void Interact()
    {
        Debug.Log("This will never run what are you doing.");
    }
}
