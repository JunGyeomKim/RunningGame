using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//サウンド管理
public class SoundManager : MonoBehaviour {

	public AudioClip Jump;
	public AudioClip Item;
	public AudioClip Click;
	public AudioClip Die;
	GameObject Sound;
	public static SoundManager instance;

	private void Awake()
	{
		if (SoundManager.instance == null)
		{
			SoundManager.instance = this;

		}
	}

	void Start()
	{
		Sound = Resources.Load("Sound") as GameObject;
	}


	public void PlayerJump()
	{
		GameObject go = Instantiate(Sound);
		AudioSource source = go.GetComponent<AudioSource>();

		source.clip = Jump;
		source.volume = 0.5f;
		source.Play();
	}

	public void PlayItem()
	{
		GameObject go = Instantiate(Sound);
		AudioSource source = go.GetComponent<AudioSource>();
		source.volume = 0.3f;
		source.clip = Item;
		source.Play();

	}

	public void PlayClick()
	{
		GameObject go = Instantiate(Sound);
		AudioSource source = go.GetComponent<AudioSource>();

		source.clip = Click;
		
		source.Play();
	}

	public void PlayDie()
	{
		GameObject go = Instantiate(Sound);
		AudioSource source = go.GetComponent<AudioSource>();

		source.clip = Die;
		 
		source.Play();
	}
}
