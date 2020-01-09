using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPlayerCol : MonoBehaviour
{
    private int timeJumped = 2;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            timeJumped--;

            //when the player Initially jumps onto the arrow
            if(timeJumped == 1)
            {
                PlayerMovement.verticalVelocity = 12.0f;
            }
            else
            {
                PlayerMovement.verticalVelocity = 20.0f;
            }
        }
    }
}
