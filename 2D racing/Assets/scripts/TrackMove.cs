﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackMove : MonoBehaviour
{
    public float speed;

    Vector2 offset;



    void  start ()
    {

    }
    void Update()
     {
        offset = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}