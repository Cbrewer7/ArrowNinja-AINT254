using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawnpoint : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField] private float repeatTime;

    private void Start()
    {
        //Create a timer to spawn an object repeatedly measured in repeatedTime
        InvokeRepeating("Spawn", 2f, repeatTime);
        Instantiate(prefab, transform.position, Quaternion.identity);
        
    }
    
    private void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
