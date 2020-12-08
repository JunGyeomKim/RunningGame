using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//サウンド破壊
public class SoundDestroy : MonoBehaviour {

	void Start()
	{
		StartCoroutine("SelfDestroy");
	}

	IEnumerator SelfDestroy()
	{
		yield return new WaitForSecondsRealtime(5.0f);
		Destroy(this.gameObject);
	}
}
