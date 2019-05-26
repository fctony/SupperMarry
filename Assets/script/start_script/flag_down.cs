using UnityEngine;
using System.Collections;

public class flag_down : MonoBehaviour {
	public GameObject go;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = go.GetComponent<Animator>();
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag=="player")
		{
			anim.SetInteger("down",1);
		}
	}
}
