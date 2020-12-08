using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//プレハブのロゴをロードする
public class LogoManager : MonoBehaviour
{
	
	GameObject PrefabsLoad;
	GameObject newPrefab;


	private void Start()
	{
		PrefabsLoad = Resources.Load("Prefabs/PF_UI_LOGO")as GameObject;
		newPrefab = Instantiate(PrefabsLoad) as GameObject;
		newPrefab.name = "PF_UI_LOGO";

		
	}

}
