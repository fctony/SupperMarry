using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sucess : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag=="player")
		{
			SceneManager.LoadScene("success");
		}
	}
}
