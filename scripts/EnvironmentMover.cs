﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentMover : MonoBehaviour
{
    public float speed;
 
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
