using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SticktoWall : MonoBehaviour
{
    Rigidbody rb;

    GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        //Freeze arrow position when hits wall
        if (collision.gameObject.tag == "Wall")
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;

            transform.gameObject.tag = "StuckArrow";
        }
    }
}
