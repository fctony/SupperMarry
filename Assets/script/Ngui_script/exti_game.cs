using UnityEngine;
using System.Collections;

public class exti_game : MonoBehaviour {

	public void Exit_Game()
	{
		StartCoroutine(exi());
	}
	IEnumerator exi()
	{
		GetComponent<TweenPosition>().enabled=true;
		yield return new WaitForSeconds (0.4f);
		Application.Quit();
	}
}
