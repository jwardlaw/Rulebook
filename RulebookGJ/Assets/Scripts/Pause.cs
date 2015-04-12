using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	bool pause = false;
	private int groupWidth = 200;
	private int groupHeight = 170;

	void Start()
	{
		Time.timeScale = 1;
	}
	void OnGUI ()
	{
		if (pause == true) {

			GUI.BeginGroup (new Rect (((Screen.width / 2) - (groupWidth / 2)), ((Screen.height / 2) - (groupHeight / 2)), groupWidth, groupHeight));
			GUI.TextArea(new Rect (0,0,100, 20), "Rule");
			if(GUI.Button (new Rect(0, 60, 200, 50), "Main Menu"))
			{
				Application.LoadLevel(0);
			}
			if(GUI.Button (new Rect(0, 120, 200, 50), "Quit Game"))
			{
				Application.Quit();
			}
			GUI.EndGroup ();
		}
	}

	void Update()
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		   pause = TogglePause();
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


