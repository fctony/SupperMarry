using UnityEngine;
using System.Collections;
using System.Xml;
using UnityEngine.SceneManagement;
public class start_game : MonoBehaviour {
	XmlDocument xmlD;
	string path;
	void Start()
	{
		path=Application.streamingAssetsPath+"\\config.xml";
		xmlD=new XmlDocument();
		xmlD.Load(path);
		init();
	}

	public void startG()
	{
		StartCoroutine(star());
	}
	IEnumerator star()
	{
		GetComponent<TweenPosition>().enabled=true;
		yield return new WaitForSeconds (0.4f);
		SceneManager.LoadScene("start");
	}
	//初始化参数
	void init()
	{
		xmlD.FirstChild.SelectSingleNode("score").InnerText="0";
		xmlD.FirstChild.SelectSingleNode("menoy").InnerText="0";
		xmlD.FirstChild.SelectSingleNode("eatm").InnerText="0";
		xmlD.FirstChild.SelectSingleNode("eatf").InnerText="0";
		xmlD.Save(path);
	}
}

