using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour 
{
	// GameManager Singleton
	public GameObject gameManager;

	// ActorDatabase Singleton
	public GameObject actorDB;

	// Use this for initialization
	void Awake () 
	{
		if (GameManager.instance == null)
			Instantiate (gameManager);

		if (ActorDatabase.instance == null)
			Instantiate (actorDB);
	}
}
