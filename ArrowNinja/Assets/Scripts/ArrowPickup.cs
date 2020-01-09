using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Ammo.ammmoAmount += 10;
            FireForward.currentArrows += 10;
            Destroy(gameObject);
        }
    }
}
