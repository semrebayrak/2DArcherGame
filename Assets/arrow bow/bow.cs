﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bow : MonoBehaviour
{
    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!ESC.GameIspaused)
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 bowPos = transform.position;
            direction = MousePos - bowPos;
            FaceMouse();
        }
    }

    void FaceMouse()
    {

        transform.right = direction;
    }
}
