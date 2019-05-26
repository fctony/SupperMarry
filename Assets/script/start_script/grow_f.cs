using UnityEngine;
using System.Collections;

public class grow_f : MonoBehaviour {
	public GameObject tri_f;
	Animator anim;
	trigger_f tri;
	// Use this for initialization
	void Start () {
		tri=tri_f.GetComponent<trigger_f>();
		anim=GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(tri.grow)
		{
			StartCoroutine(grow());
		}
	}
	IEnumerator grow()
	{
		anim.SetFloat("grow",1);
		yield return new WaitForSeconds(2f);
		anim.SetFloat("grow",-1);
	}
}
