using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//UI Logo
public class UI_Logo : MonoBehaviour {
	public UIButton StartBtn;
	public UIButton ExitBtn;
	Animator Anim;
	Transform PlayerObject;
	void Start ()
	{
		Anim = transform.Find("Stage").Find("Player").GetComponent<Animator>();
		PlayerObject = transform.Find("Stage").Find("Player").GetComponent<Transform>();
		StartBtn.onClick.Add(new EventDelegate(OnClickStart));
		ExitBtn.onClick.Add(new EventDelegate(OnClickExit));
	}
	
	void Update () {
		
	}

	void StartScene()
	{
		SceneManager.LoadScene("Stage_Game");
	}


	void OnClickStart()
	{
		SoundManager.instance.PlayClick();
		PlayerObject.transform.rotation = Quaternion.Euler(0, 180, 0);
		Anim.SetInteger("Player", 5);
		Invoke("StartScene", 1.5f);
	}
	void OnClickExit()
	{
		Application.Quit();
	}
}
