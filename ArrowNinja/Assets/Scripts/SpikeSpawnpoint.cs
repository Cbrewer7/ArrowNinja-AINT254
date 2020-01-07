using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawnpoint : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField] private float repeatTime = 3f;

    private void Start()
    {
        InvokeRepeating("Spawn", 2f, repeatTime);
    }

    private void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
