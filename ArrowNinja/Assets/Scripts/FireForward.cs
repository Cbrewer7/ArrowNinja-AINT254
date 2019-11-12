using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireForward : MonoBehaviour
{

    public GameObject arrow;
    //public GameObject arrowSpawn;
    public float speed = 300f;
    //public float mouseClick;

    public int currentArrows = 5;

    // Update is called once per frame
    void Update()
    {
        if (currentArrows >= 1)
        {

            ShootArrow();
        }
    }

    void ShootArrow()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            currentArrows--;
            Debug.Log(currentArrows);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.rigidbody != null)
                {
                    //arrow = Instantiate(arrow, transform.position, transform.rotation);
                    //hit.rigidbody.AddForceAtPosition(ray.direction * speed, hit.point);
                    Debug.Log(Input.mousePosition);
                    Debug.Log(hit.transform.name);
                    GameObject newArrow = Instantiate(arrow, transform.position, Quaternion.identity) as GameObject;
                    Rigidbody newArrowRidgedbody = newArrow.GetComponent<Rigidbody>();
                    newArrowRidgedbody.AddForce(Vector3.left * speed);
                }
                else
                {
                    GameObject newArrow = Instantiate(arrow, transform.position, Quaternion.identity) as GameObject;
                    Rigidbody newArrowRidgedbody = newArrow.GetComponent<Rigidbody>();
                    newArrowRidgedbody.AddForce(Vector3.left * speed);
                }
            }

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray))
            //    Instantiate(arrow, transform.position, Quaternion.identity);
            //Rigidbody rb = arrow.GetComponent<Rigidbody>();
            //rb.velocity = Input.mousePosition * shootForce;

        }
    }
}
