using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {

	public Vector3 initialVelocity;
	public float bounceRate =1.0f;

	// Use this for initialization
	void Start () {
		rigidbody.velocity = initialVelocity;
	}
	
	void OnCollisionEnter (Collision other) {
		// When colliding with walls, no energy is lost on the bounce.
		if (other.collider.gameObject.tag == "Wall") {
			rigidbody.velocity = rigidbody.velocity.normalized * (initialVelocity.magnitude*bounceRate);
		}

	}

	void OnTriggerExit (Collider other) {
		// If game over, deactivate ball
		if (other.gameObject.tag == "Back Wall")
			this.gameObject.SetActive (false);
	}

}
