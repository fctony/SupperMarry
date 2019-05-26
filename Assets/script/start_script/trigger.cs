using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {
	//是否可以跳跃
	public bool jump=false;
	public bool enter=false;
	void OnTriggerStay2D(Collider2D col)
	{
		jump=true;
	}
	void OnTriggerExit2D(Collider2D col)
	{
		jump=false;
		enter=false;
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		enter=true;
	}
}
