using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPlayerCol : MonoBehaviour
{
    private int timeJumped = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            timeJumped--;

            //when the player Initially jumps onto the arrow
            if(timeJumped >= 1)
            {
                PlayerMovement.verticalVelocity = 10.0f;
            }
            //After the player jumps onto the arrow
            else
            {
                PlayerMovement.verticalVelocity = 15.0f;
            }
        }
    }
}
