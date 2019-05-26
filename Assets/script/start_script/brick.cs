using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {

	void OnTriggerExit2D(Collider2D col)
	{
		if(col.transform.tag=="player")
		{
			transform.parent.gameObject.SetActive(false);
		}
	}
}
