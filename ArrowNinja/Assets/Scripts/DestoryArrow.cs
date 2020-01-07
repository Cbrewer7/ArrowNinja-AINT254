using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryArrow : MonoBehaviour
{
    private int numOfjumps = 2;

    private void OnCollisionEnter(Collision collision)
    {
        //Destroys the second arrow after hitting the first already stuck in the wall
        if (collision.gameObject.tag == "StuckArrow")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "SpikeObject")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            numOfjumps--;

            if (numOfjumps == 0)
            {
                Destroy(gameObject);
            }
        }

    }

    private void PlayerInteraction()
    {

    }
}
