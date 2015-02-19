using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public static SceneManager Instance;
	
	public string[] scenes;
	
	private int currentScene = 0;
	
	void Awake() {
		if (Instance == null) {
			Instance = this;
		} else {
			Destroy(this.gameObject);
		}
		DontDestroyOnLoad(this.gameObject);
	}
	
	public void NextScene() {
		currentScene++;
		if (currentScene == scenes.Length) {
			Application.LoadLevel("MainMenu");
			currentScene = 0;
			return;
		}
		
		Application.LoadLevel(scenes[currentScene]);
	}
	
	void Update() {
		if (Input.GetKeyDown(KeyCode.Tab)) {
			NextScene();
		}
		if (Input.GetKeyDown(KeyCode.Backspace)) {
			Reset();
		}
	}
	
	public void Reset() {
		Application.LoadLevel(Application.loadedLevelName);
	}
}
