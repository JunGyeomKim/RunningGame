using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDestroy : MonoBehaviour
{
	//すべてのものを破壊するコード
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Destroy(other.gameObject);
		}
		if(other.gameObject.tag == "Enemy")
		{
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "Item")
		{
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "Building")
		{
			Destroy(other.gameObject);
		}
	}


}
