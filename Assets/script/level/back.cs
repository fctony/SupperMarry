using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour {
	bool re_back=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(re_back)
		{
			SceneManager.LoadScene("back");
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if(col.tag=="player")
		{
			re_back=false;
		}
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag=="player")
		{
			re_back=true;
		}
	}
}
