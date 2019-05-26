using UnityEngine;
using System.Collections;

public class mogu_move : MonoBehaviour {
	public int direction=1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(direction!=0)
		{
			transform.Translate(transform.right*direction*0.01f);
		}
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.transform.tag=="qiang")
		{
			direction=-1;
		}

	}
}
