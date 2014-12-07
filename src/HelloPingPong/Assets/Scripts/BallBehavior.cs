using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {

	public Vector3 initialVelocity;
	public float bounceRate =1.0f;
		// Use this for initialization
	void Start () {
		rigidbody.velocity = initialVelocity;
	}
	
	/* There is a problem with the default colisions, where the energy is being disipated. Hence,
	/* the ball eventualy stops. I tried to fix it, but this get's trigged too often.
	*/


	void OnCollisionEnter (Collision other) {
		Debug.Log ("Original velocity " + rigidbody.velocity);
		if (other.collider.gameObject.tag == "Wall") {
			rigidbody.velocity = rigidbody.velocity.normalized * (initialVelocity.magnitude*bounceRate);
			Debug.Log ("New velocity " + rigidbody.velocity);
		}
	}

}
