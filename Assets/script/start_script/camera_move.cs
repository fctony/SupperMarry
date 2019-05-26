using UnityEngine;
using System.Collections;

public class camera_move : MonoBehaviour {
	public Transform target;
	public Transform bianjie1,bianjie2;
	Vector3 distance;
	bool move=true;
	// Use this for initialization
	void Start () {
		distance=new Vector3(transform.position.x-target.position.x,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(move)
		{
			if(target.position.x<=bianjie1.position.x)
			{
				target.position= new Vector3(bianjie1.position.x+0.01f,target.position.y,target.position.z);
			}
			else if(target.position.x>=bianjie2.position.x)
			{
				target.position= new Vector3(bianjie1.position.x-0.01f,target.position.y,target.position.z);
			}
			Vector3 vec=new Vector3(transform.position.x-target.position.x,0,0);
			float dis=distance.magnitude-vec.magnitude;
			if(dis>0)
			{
				transform.Translate(new Vector3(dis,0,0));
			}
		}
		if(transform.position.x>=16.5f)
		{
			move=false;
		}
	}
}
