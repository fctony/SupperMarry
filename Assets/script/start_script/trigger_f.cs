using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class trigger_f : MonoBehaviour {

	public bool grow=false;
	bool down=false;
	//检测是否进入下一关
	void Update()
	{
		if(down && Input.GetKeyDown("s"))
		{
			StartCoroutine(Down());
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag=="player")
		{
			grow=true;
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if(col.tag=="player")
		{
			grow=false;
			down=false;
		}
	}
	void OnTriggerStay2D(Collider2D col)
	{
		down=true;
	}
	IEnumerator Down()
	{
		SceneManager.LoadScene("level2");
		yield return null;
	}
}
