using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    //Credit to Socterean
    //https://answers.unity.com/questions/610673/how-to-destory-a-gameobject-in-c-after-3-seconds.html

    float destroyTime = 4f;

    private void Start()
    {
        Destroy(gameObject, destroyTime);
    }
}
