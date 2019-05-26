using UnityEngine;
using System.Collections;

public class zidan : MonoBehaviour {
	void Update()
	{
		GetComponent<Rigidbody2D>().AddForce(transform.right*10);
		//rigidbody2D.velocity = transform.right*2;
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.transform.tag=="enemy" || col.transform.tag=="duhua")
		{
			GameObject go =GameObject.Find("Root");
			go.GetComponent<Ngui>().addScore();
			Destroy(col.gameObject);
		}
		else if(col.transform.tag=="wall" || col.transform.tag=="player")
		{
			return;
		}
		Destroy(gameObject);
	}
}
