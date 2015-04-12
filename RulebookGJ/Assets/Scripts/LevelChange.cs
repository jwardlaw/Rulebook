using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour 
{

	public AudioSource audio;

	private bool playexitsoundonce = true;

	void Awake()
	{
		audio = GetComponent<AudioSource> ();
	}
	IEnumerator AdvanceLevel()
	{
		if (playexitsoundonce) 
		{
			audio.Play ();
			playexitsoundonce = false;
		}

		yield return new WaitForSeconds (0.5f);

		float fade = GameObject.Find ("Player").GetComponent<SceneFading> ().BeginFade (1);
		yield return new WaitForSeconds (fade);
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.name == "Player") 
		{
			StartCoroutine(AdvanceLevel ());
		}
	}
}
