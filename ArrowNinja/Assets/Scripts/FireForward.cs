﻿using System.Collections;
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
            //Get Mouse Position
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Lose 1 arrow
            currentArrows--;
            Debug.Log(currentArrows);

            //If raycast is hits (information on raycast hit)
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.rigidbody != null)
                {
                    Debug.Log(Input.mousePosition);
                    Debug.Log(hit.transform.name);

                    //Creates new arrow gameobject
                    GameObject newArrow = Instantiate(arrow, transform.position, Quaternion.identity) as GameObject;
                    //Assign rigidbody to allow force to be added to the arrow into the correct direction
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
        }
    }
}
