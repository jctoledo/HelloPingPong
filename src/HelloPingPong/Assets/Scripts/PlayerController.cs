using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	static int counter =0;
	public float speed;
	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
	}

	// phisics go here
	void FixedUpdate () {
		Debug.Log ("FixUpdate " + counter++);
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime);

	}
}
