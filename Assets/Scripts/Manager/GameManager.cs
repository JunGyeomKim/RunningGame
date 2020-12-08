using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private static GameManager instance;
	public static GameManager Instance
	{
		get
		{
			return instance;
		}
	}

	public bool IsDie = false;
	float LifeTime;
	public int intLifeTime;
	public GameObject UIManagerLoad;
	GameObject newUIManager;

	private void Start()
	{
		instance = this;
		UIManagerLoad = Resources.Load("Prefabs/UIManager") as GameObject;
		newUIManager = Instantiate(UIManagerLoad);
		newUIManager.name = "UIManager";
	}

	private void Update()
	{
		if (IsDie == false)
		{
			LifeTime += Time.deltaTime;
			intLifeTime = (int)LifeTime;
		}
		else
			return;
	}
}
