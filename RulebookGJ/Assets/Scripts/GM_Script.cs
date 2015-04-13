using UnityEngine;
using System.Collections;

public class GM_Script : MonoBehaviour 
{
	public float timer;
	public Transform PlayerPos;
	public GameObject Player;
	private static GM_Script instance = null;
	public static GM_Script Instance {
		get { return instance; }
	}
	void Awake()
	{
		if (instance != null && instance != this) 
		{ 
			Destroy(gameObject); 
			return; 
		} 
		else 
		{ 
			instance = this; 
		} 
		DontDestroyOnLoad(this.gameObject); 
	}

	void Update()
	{
		Player = GameObject.Find ("Player");
		if(Player != null) {
			PlayerPos = Player.transform;
			timer += Time.deltaTime;
		}
	}

	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width -100 , 0,100, 50), timer.ToString());
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
