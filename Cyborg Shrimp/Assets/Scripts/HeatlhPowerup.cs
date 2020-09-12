using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatlhPowerup : MonoBehaviour
{
    // write a variable that is an int, named health
    
    // write an OnTriggerEnterFunction
    // write a line that adds one to the variable
    //write a line that prints to the console
    public int health;

    private void OnTriggerEnter(Collider other)
    {
        health++;
        print(health);
    }
}
