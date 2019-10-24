﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryArrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Destroys the second arrow after hitting the first already stuck in the wall
        if (collision.gameObject.tag == "StuckArrow")
        {
            Destroy(gameObject);
        }
    }
}
