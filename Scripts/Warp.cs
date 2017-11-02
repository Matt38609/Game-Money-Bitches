using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

	public Transform warpTarget;
	public Camera PlayerCamera;

	void OnTriggerEnter2D(Collider2D other)
	{
		other.gameObject.transform.position = warpTarget.position;
		PlayerCamera.transform.position = warpTarget.position;
	}
}
