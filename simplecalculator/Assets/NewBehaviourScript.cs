using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public int max = 1000;
    public int min = 1;
    public int guess;

    // Use this for initialization
    void Start () {
        print("Our game has started");
	}
	
	// Update is called once per frame
	void Update () {
       

       

        print("Welcome to Number Guesser");
        print("Pick a number between" + min + " and " + max + ".");

        //Is the value GUESS
        print("Is the number 500?");
        //Instructions - Push these buttons
        print("Up arrow for higher, Down arrow for lower, ENTER for correct");
        
        

	}
}
