using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRespawnPoint : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Transform respawnSet;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            respawnPoint.transform.position = respawnSet.transform.position;
            Destroy(gameObject);
        }
    }
}