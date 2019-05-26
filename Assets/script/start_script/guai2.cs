using UnityEngine;
using System.Collections;

public class guai2 : MonoBehaviour {
	int dir=-1;
	int time=0;
	float speed=0.01f;
	Animator anim;
	public GameObject go;
	bool did=false;
	void Start()
	{
		anim=GetComponent<Animator>();
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(transform.right*speed*dir);
		transform.localScale=new Vector3(-dir,1,1);
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.transform.tag=="player" && !did)
		{
			if(col.transform.position.y-transform.position.y>=0.1f)
			{
				anim.SetInteger("did",1);
				go.GetComponent<Ngui>().addScore();
				speed+=0.01f;
				did=true;
			}
		}
		if(col.transform.tag=="qiang" || col.transform.tag=="player")
		{
			time++;
			transform.position=new Vector3(transform.position.x-0.02f*dir,transform.position.y,transform.position.z);
			if(time%2==0)
			{
				dir=dir*-1;
			}
		}
	}
}
