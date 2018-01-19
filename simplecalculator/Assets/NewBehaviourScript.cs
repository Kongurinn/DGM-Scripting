using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public int max = 1000;
    public int min = 1;
    private int guess;
    public int count;

    // Use this for initialization
   
	
	// Update is called once per frame
	void Start () {
       

       

        print("Welcome to Number Guesser");
        print("Pick a number between" + min + " and " + max + ".");

        //Is the value GUESS
        print("Is the number" + guess +"?");
        //Instructions - Push these buttons
        print("Up arrow for higher, Down arrow for lower, ENTER for correct");

        max = max + 1;

	}

    private void NextGuess()
    {
        count--;
        //figure out how to randomize guess****************************
        guess = (min + max) / 2;
        print("Is the number " + guess + "?");
    }
    //Update is called once per frame
    void Update(){
        //Up arrow        
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            guess = (min + max) / 2;
            NextGuess();
        }

        //Down arrow
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           max = guess;
            guess = (min + max) / 2;
            NextGuess();
        }


        //Enter button
        else if (Input.GetKeyDown(KeyCode.Return)) {
            print("The computer wins!");
        }
        //How you win, count = 0*******************************************
        else if (count = 0)
        {
            print("The computer wins!");
        }
    }
 }

