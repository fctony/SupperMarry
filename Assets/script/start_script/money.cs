using UnityEngine;
using System.Collections;

public class money : MonoBehaviour {
	public GameObject go;

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.transform.tag=="player")
		{
			go.GetComponent<Ngui>().addMoney();
			Destroy(gameObject);
		}
	}
}
