using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStage : MonoBehaviour {


	public float moveSpeed = -5;
	
	void Update ()
	{
		StageMove();
	}

	//ステージ移動
	void StageMove()
	{
		transform.position += new Vector3(2*moveSpeed * Time.deltaTime, 0, 0);
	}
}
