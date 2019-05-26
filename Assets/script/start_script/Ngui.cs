using UnityEngine;
using System.Collections;
using System.Xml;
public class Ngui : MonoBehaviour {
	UILabel score;
	UILabel money;
	XmlDocument xmlD;
	XmlNode score1,menoy1;
	string path;
	//总分
	int score_Sum=0;
	//金币
	int money_Sum=0;
	// Use this for initialization
	void Start () {
		path=Application.streamingAssetsPath+"\\config.xml";
		xmlD=new XmlDocument();
		xmlD.Load(path);
		score=GetComponentsInChildren<UILabel>()[0] as UILabel;
		money=GetComponentsInChildren<UILabel>()[1] as UILabel;
		init();
	}

	//显示
	void  show() 
	{
		score.text="score:"+score_Sum;
		money.text="momey:"+money_Sum;
	}
	void init()
	{
		score1=xmlD.FirstChild.SelectSingleNode("score");
		menoy1=xmlD.FirstChild.SelectSingleNode("menoy");
		score_Sum=int.Parse(score1.InnerText);
		money_Sum=int.Parse(menoy1.InnerText);
		show();
	}
	public void addMoney()
	{
		money_Sum+=1;
		score_Sum+=10;
		save();
		show ();
	}
	public void addScore()
	{
		score_Sum+=100;
		save();
		show();
	}
	void save()
	{
		xmlD.Load(path);
		score1=xmlD.FirstChild.SelectSingleNode("score");
		menoy1=xmlD.FirstChild.SelectSingleNode("menoy");
		score1.InnerText=""+score_Sum;
		menoy1.InnerText=""+money_Sum;
		xmlD.Save(path);
	}
}
