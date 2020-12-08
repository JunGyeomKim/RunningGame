using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStage : MonoBehaviour
{
	

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Building")
		{
			Destroy(other.gameObject);
		}
	}


}


