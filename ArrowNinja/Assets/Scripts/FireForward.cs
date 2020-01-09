using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireForward : MonoBehaviour
{

    public GameObject arrow;
    public float speed = 600f;
    public static int currentArrows = 10;

    //Lock Cursor to centre screen
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
       
        //If key is pressed and ammo is greater than 0
        if (Input.GetKeyDown(KeyCode.F) && Time.time > nextFire && Ammo.ammmoAmount > 0)
        {
            //Prevents rapid fire by giving a next shot delay
            nextFire = Time.time + fireRate;

            //Get Mouse Position
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Lose 1 arrow and ammo
            currentArrows--;
            Ammo.ammmoAmount -= 1;
            
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
