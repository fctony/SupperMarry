using UnityEngine;
using System.Collections;

public class mogu : MonoBehaviour {
	public Transform tran;
	public Transform liji;
	bool grow=false;
	int once=1;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(once==1 && grow)
		{
			tran.gameObject.SetActive(true);
			once=2;
			Destroy(transform.parent.gameObject);
			liji.gameObject.SetActive(true);
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		grow=true;
	}
}
