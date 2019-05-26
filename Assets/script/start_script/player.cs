using UnityEngine;
using System.Collections;
using System.Xml;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour {
	//角色动画
	Animator anim;
	trigger tri;
	//移动速度,跳跃力
	public float speed=0.02f;
	public GameObject bullet;
	int jump=200;
	XmlDocument xmlD;
	string path;
	bool test;
	//角色的方向
	int dir=1;
	// Use this for initialization
	void Start () {
		anim=GetComponent<Animator>();
		tri=GetComponentInChildren<trigger>();
		path=Application.streamingAssetsPath+"\\config.xml";
		xmlD=new XmlDocument();
		xmlD.Load(path);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//获取横向轴的数值,获取纵向轴的数值
		float num_X,num_Y;
		num_X=Input.GetAxis("Horizontal");
		num_Y=Input.GetAxis("Vertical");
		anim.SetFloat("forward",num_X);
		if(num_X<0)
		{
			dir=-1;
			transform.localScale=new Vector3(dir,1,1);
		}
		else if(num_X>0)
		{
			dir=1;
			transform.localScale=new Vector3(dir,1,1);
		}
		transform.Translate(transform.right*speed*num_X);

		if(Input.GetKeyDown(KeyCode.Space) && tri.enter)
		{
				anim.SetFloat("up",0.5f);
				GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jump));
		}
		if(tri.enter )
		{
			if(num_Y<0)
			{
				anim.SetFloat("up",-1);
			}
			else if(!tri.jump)
			{
				anim.SetFloat("up",0);
			}
		}
		xmlD.Load(path);
		test=xmlD.FirstChild.SelectSingleNode("eatf").InnerText=="0"? false : true;
		if(test &&  Input.GetKeyDown(KeyCode.K))
		{
			Vector3 rot;
			if(dir>0)
			{
				rot=new Vector3(0,0,0);
			}
			else
			{
				rot=new Vector3(0,180,0);
			}
			Vector3 vec = new Vector3(transform.position.x+dir*0.12f,transform.position.y+0.1f,transform.position.z);
			GameObject zidan= Instantiate(bullet,vec,Quaternion.Euler(rot)) as GameObject;
			Destroy(zidan,3);
		}
		if(transform.position.y<=-2.4f)
		{
			SceneManager.LoadScene("over");
		}
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("Menu");
		}
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.transform.tag=="mogu")
		{
			xmlD.Load(path);
			xmlD.FirstChild.SelectSingleNode("eatm").InnerText=""+1;
			xmlD.Save(path);
			Destroy(col.gameObject);
		}
		else if(col.transform.tag=="flower")
		{
			xmlD.Load(path);
			xmlD.FirstChild.SelectSingleNode("eatf").InnerText=""+1;
			xmlD.Save(path);
			Destroy(col.gameObject);
		}
		else if(col.transform.tag=="enemy")
		{
			if(!col.transform.GetComponentInChildren<guaiTri>().attack)
			{
				death();
			}
		}
		else if(col.transform.tag=="duhua")
		{
			death();
		}
	}
	public void death()
	{
		switch(transform.name)
		{
		case "player1":
			//游戏结束
			SceneManager.LoadScene("over");
			break;
		case "player2":
			//游戏结束
			SceneManager.LoadScene("over");
			break;
		case "player11":
			xmlD.Load(path);
			xmlD.FirstChild.SelectSingleNode("eatm").InnerText=""+0;
			xmlD.FirstChild.SelectSingleNode("eatf").InnerText=""+0;
			xmlD.Save(path);
			break;
		case "player22":
			xmlD.Load(path);
			xmlD.FirstChild.SelectSingleNode("eatm").InnerText=""+0;
			xmlD.FirstChild.SelectSingleNode("eatf").InnerText=""+0;
			xmlD.Save(path);
			break;
		}
	}
}
