using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	bool pause = false;
	bool narration;
	bool specialPause = false;
	private int groupWidth = 200;
	private int groupHeight = 170;
	
	void Start()
	{
		Time.timeScale = 1f;
		narration = false;
		TogglePause ();

		Debug.Log ("Check");
	}
	Pause(){
		narration = true;
	}
	void OnGUI ()
	{
		if (narration == true) {
			if (pause == true && Time.timeScale != 0.5) {

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

		else {

			GUI.BeginGroup (new Rect (((Screen.width / 2) - (groupWidth / 2)), ((Screen.height / 2) - (groupHeight / 2)), groupWidth, groupHeight));
			if (GUI.Button(new Rect (0, 120, 200, 50), "Skip Narration")) {
				Camera.main.GetComponent<AudioSource>().Stop();
			}
			if(Input.GetKeyUp(KeyCode.Space))
				Camera.main.GetComponent<AudioSource>().Stop();
			GUI.EndGroup ();
		}

		
	}
	
	void Update()
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		   pause = TogglePause();
		if (!narration) {
			if (!Camera.main.GetComponent<AudioSource>().isPlaying) {
				narration = true;
				TogglePause ();
			}
		}
			//narration = false;
	}

	bool TogglePause()
	{
		if (Time.timeScale == 0f) {
			if(specialPause){
				Time.timeScale = 0.5f;
				specialPause = false;
			}else
				Time.timeScale = 1f;
			return(false);
		} else if (Time.timeScale == 0.5f) {
			if (!specialPause){
				Debug.Log ("CHECK THIS");
				Time.timeScale = 0f;
				specialPause = true;
				Debug.Log ("CHECK THIS2");
			}
			return(true);
		} else {
			Time.timeScale = 0f;
			return(true);
		}

	}
}


