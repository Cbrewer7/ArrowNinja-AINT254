using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeCollision : MonoBehaviour
{
    public static int lives = 3;

    void FixedUpdate()
    {
        //Display Game Over when out of lives
        if (lives <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    //Spike Collision removing a single life from the player
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SpikeObject")
        {
            lives--;
        }
    }

}
