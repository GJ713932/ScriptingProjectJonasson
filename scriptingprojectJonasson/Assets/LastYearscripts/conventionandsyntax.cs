using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conventionandsyntax : MonoBehaviour
{
    
    void Start()
    {
        //this line is there to tell me the x position of my project 

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground");
        }
    }
}