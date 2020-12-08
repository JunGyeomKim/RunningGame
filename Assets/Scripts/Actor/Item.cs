using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	public float moveSpeed = -1;

	void Update ()
	{
		ItemMove();
	}

	//アイテムを動くコード及びプレーヤーとの衝突
	void ItemMove()
	{
		transform.position += new Vector3(2 * moveSpeed * Time.deltaTime, 0, 0);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			SoundManager.instance.PlayItem();
			UIManager.Instance.ItemScoreFunc();
			Destroy(gameObject);
		}
	}



}
