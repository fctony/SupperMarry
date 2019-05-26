using UnityEngine;
using System.Collections;
using System.Xml;
public class player_move : MonoBehaviour {
	//角色数组
	public GameObject[] player;
	//角色脚本
	//是否吃了蘑菇
	bool eatMushroom;
	//是否吃了花
	bool eatFlower;
	//是否被攻击到
	public bool actic=false;
	//记录当前的人物编号
	int roleIndex=0;
	XmlDocument xmlD;
	string path;
	// Use this for initialization
	void Start () {
		path=Application.streamingAssetsPath+"\\config.xml";
		xmlD=new XmlDocument();
		xmlD.Load(path);
		eatMushroom=xmlD.FirstChild.SelectSingleNode("eatm").InnerText=="0"? false: true;
		eatFlower=xmlD.FirstChild.SelectSingleNode("eatf").InnerText=="0"? false : true;
		role();
	}

	void Update () {
		xmlD.Load(path);
		eatMushroom=xmlD.FirstChild.SelectSingleNode("eatm").InnerText=="0"? false: true;
		eatFlower=xmlD.FirstChild.SelectSingleNode("eatf").InnerText=="0"? false : true;
		role();
		if(Input.GetAxis("Horizontal")!=0)
		{
			transform.position = new Vector3(player[roleIndex].transform.localPosition.x+transform.position.x,transform.position.y,transform.position.z);
			player[roleIndex].transform.localPosition=new Vector3(0,player[roleIndex].transform.localPosition.y,0);

		}
	}

	//判断人物
	void role()
	{
		if(!eatMushroom && !eatFlower)
		{
			//小红人
			showRole(0);
		}
		else if(eatMushroom && !eatFlower)
		{
			//大红人
			showRole(2);
		}
		else if(!eatMushroom && eatFlower)
		{
			//小白人
			showRole(1);
		}
		else
		{
			//大白人
			showRole(3);
		}
	}

	//显示人物
	void showRole(int index)
	{
		if(index!=roleIndex)
		{
			HideRole();
			roleIndex=index;
			player[roleIndex].SetActive(true);
		}
	}
	//隐藏所有人物
	void HideRole()
	{
		for(int i=0;i<player.Length;i++)
		{
			player[i].SetActive(false);
		}
	}
}
