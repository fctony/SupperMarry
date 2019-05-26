using UnityEngine;
using System.Collections;

public class open_option : MonoBehaviour {
	public GameObject go;
	public void open_Op()
	{
		StartCoroutine(ope());
	}
	IEnumerator ope()
	{
		GetComponent<TweenPosition>().enabled=true;
		yield return new WaitForSeconds (0.4f);
        if(go.activeSelf==false){
             go.SetActive(true);
        }
        else
        {
            go.SetActive(false);
        }
		
	}
}
