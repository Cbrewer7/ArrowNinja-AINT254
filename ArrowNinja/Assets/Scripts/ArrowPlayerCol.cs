using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPlayerCol : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerMovement.verticalVelocity = 12.0f;
        }
    }
}
