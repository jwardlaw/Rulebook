using UnityEngine;
using System.Collections;

public class LastLevel : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
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
		yield return new WaitForSeconds(30);
		Destroy (gameObject);
	}

	IEnumerator FadeScene()
	{
		yield return new WaitForSeconds (33);
		Application.LoadLevel (0);
	}
}
