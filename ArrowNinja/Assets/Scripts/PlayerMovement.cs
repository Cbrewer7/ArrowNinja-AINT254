using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float playerSpeed = 5.0f;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(0, 0, Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed);
    }
}
