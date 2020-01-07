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

    private void Start()
    {
        Cursor.lockState =  CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentArrows >= 1)
        {
            ShootArrow();
        }
    }

    public float fireRate = 0.5f;
    private float nextFire = 0f;

    void ShootArrow()
    {
       

        if (Input.GetKeyDown(KeyCode.F) && Time.time > nextFire)
        {
            //Prevents rapid fire by giving a next shot delay
            nextFire = Time.time + fireRate;

            //Get Mouse Position
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Lose 1 arrow
            currentArrows--;
            //Debug.Log(currentArrows);

            //If raycast is hits (information on raycast hit)
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.rigidbody != null)
                {
                    Debug.Log(Input.mousePosition);
                    //Debug.Log(hit.transform.name);

                    //Creates new arrow gameobject
                    GameObject newArrow = Instantiate(arrow, transform.position, Quaternion.identity) as GameObject;
                    //Assign rigidbody to allow force to be added to the arrow into the correct direction
                    Rigidbody newArrowRidgedbody = newArrow.GetComponent<Rigidbody>();
                    newArrowRidgedbody.AddForce(Vector3.left * speed);
                }
            }
        }
    }
}
