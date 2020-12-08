using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//プレイヤー死亡衝突処理とスコアUIロード
public class PlayerDead : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			//Debug.Log("GameOver");
			PlayerController.Instance.PlayerDie();
			Invoke("NextScene", 3);
		}
	}

	void NextScene()
	{
		//GameManager.Instance.ScoreUI();
	}
	
}
