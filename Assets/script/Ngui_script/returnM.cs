using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class returnM : MonoBehaviour {
	public GameObject go;
	public void hide()
	{
		go.SetActive(false);
		SceneManager.LoadScene("Menu");
	}
}
