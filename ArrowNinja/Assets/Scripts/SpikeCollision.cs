﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeCollision : MonoBehaviour
{
    [SerializeField] private int lives = 3;

    void FixedUpdate()
    {
        //Display Game Over
        if (lives <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    //Spike Collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SpikeObject")
        {
            lives--;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SpikeObject")
        {
            lives--;
        }
    }

}
