using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MattPControl : MonoBehaviour {

	public float movespeed;
	private float lastdirX;
	private float lastdirY;
	private Rigidbody2D PlayerRigidBody;
	Animator anim;


	// Use this for initialization
	void Start () {
		PlayerRigidBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		//Gets X direction
		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) {
			//Moves in the X direction
			PlayerRigidBody.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * movespeed, PlayerRigidBody.velocity.y);
			//Animates Horizontal walking animation
			anim.SetBool ("IsMoving", true);
			lastdirX = Input.GetAxisRaw ("Horizontal");
			anim.SetFloat ("InputX", lastdirX);

		}
		//Gets Y direction
		if (Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw ("Vertical") < -0.5f) {
			//Moves in the Y direction
			PlayerRigidBody.velocity = new Vector2 (PlayerRigidBody.velocity.x, Input.GetAxisRaw ("Vertical") * movespeed);
			//Animates Vertical walking animation
			anim.SetBool ("IsMoving", true);
			lastdirY = Input.GetAxisRaw ("Vertical");
			anim.SetFloat ("InputY", lastdirY);
		}

		//Stops movement if X dir is not pressed
		if (Input.GetAxisRaw ("Horizontal") < 0.5f && Input.GetAxisRaw ("Horizontal") > -0.5f) {
			PlayerRigidBody.velocity = new Vector2 (0f, PlayerRigidBody.velocity.y);
			anim.SetFloat ("InputX", 0f);
		}
		//Stops movement if Y dir is not pressed
		if (Input.GetAxisRaw ("Vertical") < 0.5f && Input.GetAxisRaw ("Vertical") > -0.5f) {
				PlayerRigidBody.velocity = new Vector2 (PlayerRigidBody.velocity.x, 0f);
				anim.SetFloat ("InputY", 0f);
		} 
		if (Input.GetAxisRaw ("Horizontal") < 0.5f && Input.GetAxisRaw ("Horizontal") > -0.5f && Input.GetAxisRaw ("Vertical") < 0.5f && Input.GetAxisRaw ("Vertical") > -0.5f)
		{	
			//Animates Idle Position
			if (Mathf.Abs (Input.GetAxisRaw ("Horizontal")) * Time.deltaTime > Mathf.Abs (Input.GetAxisRaw ("Vertical")) * Time.deltaTime) {
				anim.SetFloat ("InputX", lastdirX);
				anim.SetFloat ("InputY", 0f);
			} else {
				anim.SetFloat ("InputX", 0f);
				anim.SetFloat ("InputY", lastdirY);
			}
			anim.SetBool ("IsMoving", false);
		}
	}
}
