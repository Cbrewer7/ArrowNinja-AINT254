using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        if(SpikeCollision.lives > 0)
        {
            text.text = "Lives: " + SpikeCollision.lives;
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
