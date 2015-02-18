using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	public bool isTriggered;
	public GameObject target;
	
	void OnTriggerEnter2D(Collider2D c) {
		if (c.gameObject.name == target.name) {
			isTriggered = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D c) {
		if (c.gameObject.name == target.name) {
			isTriggered = false;
		}
	}
}
