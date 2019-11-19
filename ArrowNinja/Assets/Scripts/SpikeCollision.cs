using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCollision : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    //Spike collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SpikeObject")
        {
            Destroy(gameObject);
        }
    }
}
