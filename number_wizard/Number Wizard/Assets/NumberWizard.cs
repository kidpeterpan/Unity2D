using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess; // first answer
    // Start is called before the first frame update
    void Start()
    {
        StartGame();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            min = guess;
            NextGuess();

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genuis.");
            StartGame();
        }
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Yahooooooo, Welcome to number wizard game.");
        Debug.Log("Maximum number you can guest is " + max);
        Debug.Log("Minimum number you can guest is " + min);
        Debug.Log("Is number equals to " + guess + "?");
        Debug.Log("Push up = higher, Push down = lower, Enter = correct");
        max = max + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than : " + guess);
    }
}
