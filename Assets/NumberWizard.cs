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
        Debug.Log("Welcome to the show");
        Debug.Log("Pick a number between " + min + " and " + max);
        Debug.Log("Tell me if your number is higher or lower than");
        Debug.Log("Push up if higher");
        Debug.Log("Push down if lower");
        Debug.Log("Push enter if correct");
        Debug.Log("Is your number higher or lower than " + guess + "?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            Debug.Log("Up arrow pressed");
            min = guess;
            //Debug.Log("UPDATED MIN" + guess);
            guess = (max + min) / 2;
            Debug.Log("Is your number higher or lower than " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow pressed");
            max = guess;
            //Debug.Log("UPDATED MAX" + max);
            guess = (max + min) / 2;
            Debug.Log("Is your number higher or lower than " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("NEAT. YOUR NUMBER WAS " + guess);
        }
    }
}
