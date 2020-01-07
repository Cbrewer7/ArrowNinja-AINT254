using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ammo : MonoBehaviour
{
    Text text;
    public static int ammmoAmount = 10;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        if(ammmoAmount > 0)
        {
            text.text = "X" + ammmoAmount + " Arrows";
        }
        else
        {
            text.text = "X0 Arrows";
        }
    }
}
