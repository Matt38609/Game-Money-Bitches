using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	// This will manage all of the game state
	// GameManager is a singleton. This means only one instance of it
	// exists throughout the game and is loaded with Loader.cs when the game
	// starts

	public static GameManager instance = null;

	public bool isPaused = false;
	private string playerName; 

	// Use this for initialization
	void Awake () 
	{
		// This will make sure only one instance exists
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		// if we change scenes, GameManager singleton won't get destroyed
		// changing scenes destroys the heirarchy for that scene
		DontDestroyOnLoad (gameObject);

		InitGame ();
	}

	// This is where we need to initialise anything before game starts
	void InitGame()
	{
		
	}

	// This will get called by a script to indicate game is over and
	// disable the GameManager
	public void GameOver()
	{
		enabled = false;
	}

	public void Pause()
	{
		isPaused = !isPaused;
	}
	
	// This is where we can put things to happen in the background of the game
	// move enemies, place monsters, move npcs, etc. 
	void Update () {

		//Gets players name that is entered in the titlemenuoptions
		//playerName = GameObject.Find("NameEnter").GetComponent<Text>().text;
	}
}
