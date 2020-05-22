using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = (1000 + 1) / 2;


    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to the show");
        Debug.Log("Pick a number between " + min + " and " + max);
        Debug.Log("Tell me if your number is higher or lower than");
        Debug.Log("Push up if higher");
        Debug.Log("Push down if lower");
        Debug.Log("Push enter if correct");
        Debug.Log("Is your number higher or lower than " + guess + "?");
        max = max + 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            Debug.Log("Up arrow pressed");
            min = guess;
            NextGuess();
            Debug.Log("Is your number higher or lower than " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow pressed");
            max = guess;
            NextGuess();
            Debug.Log("Is your number higher or lower than " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("NEAT. YOUR NUMBER WAS " + guess);
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }
}
