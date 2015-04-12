using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour 
{
	void AdvanceLevel()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.name == "Player") 
		{
			AdvanceLevel ();
		}
	}
}
