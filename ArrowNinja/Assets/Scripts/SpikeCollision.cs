using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCollision : MonoBehaviour
{
    int lives = 3;

    void Update()
    {
        //Display Game Over
        if (lives <= 0)
        {

        }
    }

    //Spike collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SpikeObject")
        {
            lives--;
            Destroy(gameObject);
        }
    }
}
