using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//プレイヤーの行動実装
public class PlayerController : MonoBehaviour
{
	private static PlayerController instance;
	public static PlayerController Instance
	{
		get
		{
			return instance;
		}
	}

	Animator PlayerAni = null;
	Rigidbody rigidbody;
	bool IsJump = true;
	bool IsJumpDouble = false;
	

	float jumpPower = 6.0f;


	void Start()
	{
		instance = this;
		PlayerAni = gameObject.GetComponent<Animator>();
		rigidbody = GetComponent<Rigidbody>();
		CreateManager.Instance.SetPlayer(transform);

	}

	
	void PlayerJump()
	{
		rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Building")
		{
			IsJump = true;
			IsJumpDouble = false;
			PlayerAni.SetInteger("Player", 1);
		}
	}

	//ダブルジャンプの実装
	public void PlayerJumpFunc()
	{
		
		{
			if (IsJumpDouble == true)
			{
				SoundManager.instance.PlayerJump();
				PlayerJump();
				IsJumpDouble = false;
				PlayerAni.SetInteger("Player", 3);
			}

			if (IsJump == true)
			{
				SoundManager.instance.PlayerJump();
				PlayerJump();
				IsJump = false;
				IsJumpDouble = true;
				PlayerAni.SetInteger("Player", 2);

			}
		}
	}

	//プレイヤー死亡時ロード効果
	public void PlayerDie()
	{
		SoundManager.instance.PlayDie();
		GameManager.Instance.IsDie = true;
		PlayerAni.SetInteger("Player", 6);
		UIManager.Instance.GameOverUI();
	}

}
	
