using UnityEngine;
using System.Collections;
using System.Xml;
using UnityEngine.SceneManagement;
public class exit_again : MonoBehaviour {
	XmlDocument xmlD;
	string path;
	void Start()
	{
		path=Application.streamingAssetsPath+"\\config.xml";
		xmlD=new XmlDocument();
		xmlD.Load(path);
		//init();
	}
	public void Exit_g()
	{
		Application.Quit();
	}
	public void Again_g()
	{
		init();
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
