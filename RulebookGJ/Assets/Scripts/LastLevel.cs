using UnityEngine;
using System.Collections;

public class LastLevel : MonoBehaviour {

	public AudioSource audio;

	// Use this for initialization
	void Start () 
	{
		audio = GetComponent<AudioSource>();
		if (gameObject.name == "Player") 
		{
			StartCoroutine (FadeScene ());
		} 
		else if (gameObject.name == "Future Player") 
		{
			StartCoroutine (FadeDelete ());
		}
	}
	
	IEnumerator FadeDelete()
	{
		yield return new WaitForSeconds(32);
		audio.Play();
		yield return new WaitForSeconds (0.2f);
		Destroy (gameObject);
	}

	IEnumerator FadeScene()
	{
		yield return new WaitForSeconds (33);
		Application.LoadLevel (0);
	}
}
