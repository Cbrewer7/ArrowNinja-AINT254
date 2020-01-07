using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    public bool contact = false;

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        contact = true;
    //        player.transform.position = respawnPoint.transform.position;
    //    }
    //}

    //Vector3 respawnLoc = new Vector3(-0.3f, 0.5f, 0f);

    //Quaternion startRotation = Quaternion.Euler(Vector3.zero);

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            contact = true;
            //player.transform.SetPositionAndRotation(respawnLoc, startRotation);
        }
    }

}
