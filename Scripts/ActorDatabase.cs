using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// At some point we should have all of the actors in a XML, CSV, or JSON file
// and load it in and init the db with that.
// i.e. read a text file of whatever format with all the actors,
// then load each entry into the db as an actor object

// for now we can load in a few in InitDB to get stuff working
public class ActorDatabase : MonoBehaviour 
{
	// This will manage all of the game state
	// ActorDatabase is a singleton. This means only one instance of it
	// exists throughout the game and is loaded with Loader.cs when the game
	// starts

	public static ActorDatabase instance = null;

	// we could use an array/List or Dictionary, doesn't really matter
	public Dictionary<string, Actor> db;

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

		InitDB ();
	}

	// this is where we fill our db with actors ONCE everytime the game starts
	private void InitDB()
	{
		// Make a dictionary
		db = new Dictionary<string, Actor> ();

		string name = "Bob";

		// create a new Actor
		Actor bob = new Actor (name, Actor.Type.normal, "Bobby O", 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f);

		// add actor with key: id, value, Actor
		db.Add (name, bob);

		// i just print some here to see it working
		Actor val;
		if (db.TryGetValue ("Bob", out val))
			Debug.Log(val.ToString());
	}
}