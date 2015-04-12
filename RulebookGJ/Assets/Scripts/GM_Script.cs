using UnityEngine;
using System.Collections;

public class GM_Script : MonoBehaviour {

	private static GM_Script instance = null;
	public static GM_Script Instance {
		get { return instance; }
	}
	void Awake()
	{ 
		if (instance != null && instance != this) 
		{ 
			Destroy(instance.gameObject); 
			return; 
		} 
		else 
		{ 
			instance = this; 
		} 
		DontDestroyOnLoad(this.gameObject); 
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
