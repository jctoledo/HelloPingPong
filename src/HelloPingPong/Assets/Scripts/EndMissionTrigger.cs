using UnityEngine;
using System.Collections;

public class EndMissionTrigger : MonoBehaviour {
	public GameObject gameOverText;

	// What to do once the ball has reached an end
	void OnTriggerExit (Collider other) {
		gameOverText.SetActive (true);
	}
}
