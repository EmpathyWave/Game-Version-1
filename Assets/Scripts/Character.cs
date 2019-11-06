using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
//abstract class for each character which has their own state 
//being slightly solved and not, different knots
{
    public bool active;
    public int state;

    //later check if the player is sitting
    private void OnTriggerEnter(Collider other)
    {
        if(Input.GetKey(KeyCode.T))
        {
            //calling greet file
            //opens up input field
        }
    }
    //create a character class that acesses specific parts of the json file
    
}
