using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Deals with the New Game Button
	public void NewGame()
	{
		// Loads scene by index number indicated in build settings under file in unity
		SceneManager.LoadScene (1);
	}

	// Deals with the Continue Game Button
	public void ContinueGame()
	{
		
	}

	//Deals with the Load Save Button
	public void LoadSave()
	{

	}
}