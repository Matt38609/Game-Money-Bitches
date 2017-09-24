using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public int moveSpeed;


	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(Vector3.up * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
		transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime);
	}
}
