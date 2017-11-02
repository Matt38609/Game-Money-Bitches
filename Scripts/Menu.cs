/*
 * This doesn't seem to work.
 * The menu spawns at the start every time and takes 2 key presses to turn off.
 * Maybe MainMenu.cs is doing something?
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour 
{

	//Basic objects
	//I believe PauseMenu, being a GameObject, causes "Update" to not verify the first time through
	public GameObject PauseMenu;

	//if GameObject is the issue, swap to FixedUpdate()???
	void Update () 
	{
		if (Input.GetKeyDown("return")) 
		{
			GameManager game = GameManager.instance;

			// Pause the game
			game.Pause ();

			//The Menu swaps active status based on Paused
			PauseMenu.SetActive(game.isPaused);
		}
	}
}
