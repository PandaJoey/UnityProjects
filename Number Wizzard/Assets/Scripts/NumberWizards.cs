using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {
    private int max = 1000;
    private int min = 1;
    private int guess = 500;
    // Use this for initialization
    void Start() {
        StartGame();

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
          
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {
            print("I Won");
            guess = 500;
            StartGame();
        }

    }

    private void StartGame() {
        max = max + 1;
        print("=============================");
        print("Welcome to Number Wizard");
        print("Pick a number between " + min + " and " + max + " don't tell me");
        print("Is the number highter or lower than " + guess + "?");
       
    }

    private void NextGuess() {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess + "?");
        print("Up arrow = higher, Down Arrow = lower, Return = equal");
    }

}

