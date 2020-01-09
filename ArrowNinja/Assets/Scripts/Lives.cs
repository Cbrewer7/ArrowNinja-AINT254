using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    Text text;

    public GameObject prefab;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        if(SpikeCollision.lives > 0)
        {
            //Change text component in UI
            text.text = "Lives: " + SpikeCollision.lives;
        }
        else
        {
            //Load Scene on 0 lives and unlock the cursor
            
            SceneManager.LoadScene(0);
            //Instantiate(prefab, transform.position, Quaternion.identity);

        }
    }
}
