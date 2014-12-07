using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {

	public Vector3 initialVelocity;
	
		// Use this for initialization
	void Start () {
		rigidbody.AddForce (initialVelocity);
	}

}
