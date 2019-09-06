using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var maxGuess = 1000;
        var minGuess = 1;
       Debug.Log("Welcome to Number Wizard");

       Debug.Log("Pick A Number, don't tell me what it is");


       Debug.Log("Highest Number that you can pick is " + maxGuess);

       Debug.Log("Lowest Number that you can pick is " + minGuess);  
       Debug.Log("Tell me if your number is higher or lower than my guess");
       Debug.Log("Push UP = Higher, Push DOWN = Lower, Press ENTER for correct");
    }

    // Update is called once per frame
    void Update()
    {
        //Setup the arrow keys to check to see if they were pressed
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You Pressed the Down Arrow");
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You pressed the Up Arrow");
        }
        if(Input.GetKeyDown(KeyCode.Return))
         {
            Debug.Log("You pressed the enter key");
         }
    }
}
