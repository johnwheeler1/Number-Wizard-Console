using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int _maxGuess = 1000;
    private int _minGuess = 1;
    private int _guess = 500;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Gamer, You Pressed Up.");
            _minGuess = _guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Gamer, You Pressed Down.");
            _maxGuess = _guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Gamer, You Pressed Enter, I am Correct!");
            StartGame();
        }
    }

    private void StartGame()
    {
        _maxGuess = 1000;
        _minGuess = 1;
        _guess = 500;
        
        Debug.Log("Welcome to Number Wizard Console, Gamers!");
        Debug.Log("Gamers, Pick a Number, Don't Tell me What it is...");
        Debug.Log("Gamers, Pick a Number Between " + _minGuess + " and " + _maxGuess);
        Debug.Log("The Highest Number You Can Pick is: " + _maxGuess);
        Debug.Log("The Lowest Number You Can Pick is: " + _minGuess);
        Debug.Log("Tell Me if Your Number is Higher or Lower than: " + _guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Enter = Correct");
        _maxGuess++;
    }

    private void NextGuess()
    {
        _guess = (_maxGuess + _minGuess) / 2;
        Debug.Log("Gamers, Is Your Guess Higher or Lower than... " + _guess);
    }
}
