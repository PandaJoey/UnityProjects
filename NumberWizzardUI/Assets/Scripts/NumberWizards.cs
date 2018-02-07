using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour {
    private int max = 1000;
    private int min = 1;
    private int guess;
    public int maxGuessesAllowed = 10;
    public Text text;
    // Use this for initialization
    void Start() {
        StartGame();
    }

    public void GuesHigher() {
        min = guess;
        NextGuess();
    }

    public void GuessLower() {
        max = guess;
        NextGuess();
    }

    private void StartGame() {
        NextGuess();
    }

    private void NextGuess() {
        guess = Random.Range(min, max+1);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed -1;
        if(maxGuessesAllowed <= 0) {
            SceneManager.LoadScene("Win");
        }
    }

}

