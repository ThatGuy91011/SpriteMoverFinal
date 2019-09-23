using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PScript : MonoBehaviour
{
    private int PCheck = 0; //Variable to check if P has been pressed twice
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If P is pressed and the component is disabled...
        if (Input.GetKeyDown(KeyCode.P) && PCheck == 1)
        {
            //...enable the component.
            GetComponent<SpriteMover>().enabled = true;
            //...and set this variable to zero, meaning the component is now active
            PCheck = 0;
        }
        //If P is pressed and the component is enabled...
        else if (Input.GetKeyDown(KeyCode.P))
        {
            //...disable the component.
            GetComponent<SpriteMover>().enabled = false;
            //...and set this variable to one, meaning that the component is now inactive
            PCheck = 1;
        }

    }
}
