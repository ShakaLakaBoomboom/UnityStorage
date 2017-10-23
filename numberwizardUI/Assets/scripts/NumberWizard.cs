using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int maxnumber = 1000;//variable for largest number, this is a global variable as it is out of start function
    int minnumber = 1;//variable for smallest number, int is the type and minnumber is the name
    int guess=500;//variable that holds the middle value
    int maxNumofGuesses = 3;

    public Text guessText;

    public void GuessHigher() {
        minnumber = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        maxnumber = guess;
        NextGuess();
    }

    void StartGame() {
        print("welcome to a game of Number Wizard"); //console will display what is between the ""
        NextGuess();
    }

    void NextGuess() {
        guess=Random.Range(minnumber, maxnumber + 1) ;
        //conv guess to string and updates text
        guessText.text = guess.ToString();
        maxNumofGuesses--;
        if (maxNumofGuesses == 0)
        {
            SceneManager.LoadScene("Win");
        }

    }

    void Start () {
        guess = Random.Range(minnumber, maxnumber + 1);
        guessText.text = guess.ToString();
        
	}
	
	// Update is called once per frame

}
