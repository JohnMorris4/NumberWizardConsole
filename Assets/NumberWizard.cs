using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    //Variables placed at class level
    int maxGuess;
    int minGuess;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
       StartGame();
    }
    void StartGame() 
    {
        maxGuess = 1000;
        minGuess = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick A Number, don't tell me what it is");
        Debug.Log("Highest Number that you can pick is " + maxGuess);
        Debug.Log("Lowest Number that you can pick is " + minGuess);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push UP = Higher, Push DOWN = Lower, Press ENTER for correct");
        maxGuess = maxGuess + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Setup the arrow keys to check to see if they were pressed
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            minGuess = guess;
            NextGuess();
        }
         else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            maxGuess = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
         {
            Debug.Log("You pressed the enter key");
            StartGame();
         }
    }

    void NextGuess()
    {
        guess = (maxGuess + minGuess) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }
}
