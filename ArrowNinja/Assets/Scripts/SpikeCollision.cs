using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeCollision : MonoBehaviour
{
    public static int lives = 3;

    void FixedUpdate()
    {
        //Display Game Over
        if (lives <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    public Transform respawnPoint;
    Transform respawn;

    //Spike Collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SpikeObject")
        {
           
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
