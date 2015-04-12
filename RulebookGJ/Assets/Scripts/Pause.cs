using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	float timer = 0;
	bool pause = false;
	bool narration;
	float timeForAudio;
	private int groupWidth = 200;
	private int groupHeight = 170;
	
	void Start()
	{
		timeForAudio = Camera.main.GetComponent<AudioSource>().clip.length;
		Time.timeScale = 1;
		narration = false;
		TogglePause ();
		//narration = false;
		//TogglePause ();
		//narration = true;

		Debug.Log ("Check");
	}
	Pause(){
		narration = true;
	}
	void OnGUI ()
	{
		if (narration == true) {
			if (pause == true) {

				GUI.BeginGroup (new Rect (((Screen.width / 2) - (groupWidth / 2)), ((Screen.height / 2) - (groupHeight / 2)), groupWidth, groupHeight));
				GUI.TextArea (new Rect (0, 0, 100, 20), "Rule");
				if (GUI.Button (new Rect (0, 60, 200, 50), "Main Menu")) {
					Application.LoadLevel (0);
				}
				if (GUI.Button (new Rect (0, 120, 200, 50), "Quit Game")) {
					Application.Quit ();
				}
				GUI.EndGroup ();
			}
		} 
	//else {
		//	Debug.Log ("Checker2");
		//	InvokeRepeating("OHHH", 10 , 0);
		//	pause = TogglePause();
		//}
	}

	void Update()
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		   pause = TogglePause();
		timer = Time.realtimeSinceStartup;
		if (!narration) {
			if (timer >= timeForAudio+1) {
				narration = true;
				TogglePause ();
			}
		}
			//narration = false;
	}

	bool TogglePause()
	{
		if (Time.timeScale == 0) {
			Time.timeScale = 1;
			return(false);
		} else {
			Time.timeScale = 0;
			return(true);
		}
	}
}


