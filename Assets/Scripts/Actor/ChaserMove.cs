using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserMove : MonoBehaviour
{
	public Transform Playertarget;
	public Transform TARGET
	{
		set
		{
			Playertarget = value;
		}
	}

	//プレーヤーを追っかけて行くことにするコード
	void Move()
	{
		if(Playertarget != null)
		{
			transform.position =  Vector3.Lerp(transform.position, Playertarget.position, Time.deltaTime);

			Vector3 dir = Playertarget.transform.position - transform.position;
			this.transform.rotation =
				Quaternion.Lerp(
					this.transform.rotation,
					Quaternion.LookRotation(dir),
					Time.deltaTime * 10);
		}
	}
}
