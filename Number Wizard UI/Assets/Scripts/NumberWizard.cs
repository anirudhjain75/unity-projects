using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Use this for initialization
    private void Start()
    {
        StartGame();
    }

    private void StartGame() {
        generateRandomNumber(min, max);
        guessText.text = guess.ToString();
        max = max + 1;
    }

    public void OnPressHigher() {
        min = guess;
        NextGuess();
    }

    public void OnPressLower() {
        max = guess;
        NextGuess();
    }

    private void NextGuess()
    {
        generateRandomNumber(min, max);
        guessText.text = guess.ToString();
    }

    private void generateRandomNumber(int lowerLimit, int upperLimit) {
        int newGuess = Random.Range(lowerLimit, upperLimit + 1);
        if (newGuess == guess) {
            newGuess = Random.Range(lowerLimit, upperLimit + 1);
        }
        guess = newGuess;
    }
}
