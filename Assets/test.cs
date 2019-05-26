using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay2D(Collider2D col)
	{
		print("keyi");
	}
	void OnTriggerExit2D(Collider2D col)
	{
		print ("bukeyi");
	}
}
