using UnityEngine;
using System.Collections;

public class GoalManager : MonoBehaviour {

	public Goal[] goals;
	public GameObject winScreen;
	
	bool callOnce = true;
	// Update is called once per frame
	void Update () {
		bool allGoals = true;
		for (int i = 0; i < goals.Length; i++) {
			if (goals[i].isTriggered == false) {
				allGoals = false;
			}
		}
		
		if (allGoals && callOnce) {
			callOnce = false;
			StartCoroutine(Win ());	
		}
	}
	
	IEnumerator Win() {
		winScreen.SetActive(true);
		yield return new WaitForSeconds(5f);
		Application.LoadLevel("MainMenu");
	}
}
