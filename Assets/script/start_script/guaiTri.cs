using UnityEngine;
using System.Collections;

public class guaiTri : MonoBehaviour {
	//怪物是否被攻击
	public bool attack=false;
	void OnTriggerExit2D(Collider2D col)
	{
		if(col.tag=="player")
		{
			attack=false;
		}
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag=="player")
		{
			attack=true;
		}
	}
}
