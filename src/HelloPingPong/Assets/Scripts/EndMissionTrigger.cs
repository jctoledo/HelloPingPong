using UnityEngine;
using System.Collections;

public class EndMissionTrigger : MonoBehaviour {

	// What to do once the ball has reached an end
	void OnTriggerExit (Collider other) {
		Debug.Log ("Wall was triggered");
	}
}
