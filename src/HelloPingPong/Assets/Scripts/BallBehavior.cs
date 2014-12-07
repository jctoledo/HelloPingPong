using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {

	public Vector3 initialVelocity;
	
		// Use this for initialization
	void Start () {
		rigidbody.velocity = initialVelocity;
	}
	
	/* There is a problem with the default colisions, where the energy is being disipated. Hence,
	/* the ball eventualy stops. I tried to fix it, but this get's trigged too often.
	*/

	/*
	void OnCollisionExit (Collision other) {

		Debug.Log ("initial vel: " + rigidbody.velocity + " rel vel: " + other.relativeVelocity);
		rigidbody.velocity = other.relativeVelocity * 1.0f;
		Debug.Log ("final vel: " + rigidbody.velocity);
	}
	*/
}
