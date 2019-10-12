using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float playerSpeed = 5.0f;

    public float jumpHeight = 5.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Player can move left to right on a single axis
        transform.Translate(0, 0, Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed);

        // Player can jump using spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
        }
    }
}
