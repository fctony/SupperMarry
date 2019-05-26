using UnityEngine;
using System.Collections;

public class guai1 : MonoBehaviour {
	int dir=-1;
	int time=0;
	Animator anim;
	public GameObject go;
	void Start()
	{
		anim=GetComponent<Animator>();
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(transform.right*0.01f*dir);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.transform.tag=="player")
		{
			if(col.transform.position.y-transform.position.y>=0.1f)
			{
				anim.SetInteger("did",1);
				GetComponent<Collider2D>().enabled=false;
				StartCoroutine(did());
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
	IEnumerator did()
	{
		for(int i=0;i<20;i++)
		{
			yield return null;
		}
		Destroy(transform.gameObject);
		go.GetComponent<Ngui>().addScore();
	}
}
