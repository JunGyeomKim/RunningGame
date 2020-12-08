using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//すべてのオブジェクトの生成を管理する
public class CreateManager : MonoBehaviour
{

	private static CreateManager instance;
	public static CreateManager Instance
	{
		get
		{
			return instance;
		}
	}

	Transform PlayerTrans;

	public GameObject[] OriginStage;
	GameObject newStage;
	float InvokeRepeat = 5f;

	public GameObject OriginChaser;
	GameObject newChaser;
	
	public GameObject OriginItem;
	GameObject newItem;

	void Start()
	{
		instance = this;
		InvokeRepeating("newCreateStage", 0, InvokeRepeat);
		InvokeRepeating("newCreateItem", 0, InvokeRepeat);
	}


	void Update()
	{
	}

	void newCreateStage()
	{
		int RandomStageNum;
		RandomStageNum = Random.Range(0, 5);
		newStage = Instantiate(OriginStage[RandomStageNum], new Vector3(10, 0, 0), transform.rotation);
	}

	void newCreateChaserEnemy()
	{
		newChaser = Instantiate(OriginChaser, new Vector3(Random.Range(10,20),20,0), transform.rotation);
		newChaser.GetComponent<ChaserMove>().TARGET = PlayerTrans.transform;
	}

	void newCreateItem()
	{

		for(int i = 8; i<15; i++)
		{
			for(int j = 10; j<20; j++)
			{
				newItem = Instantiate
					(OriginItem, new Vector3(j, i, 0), transform.rotation);
			}
		}

	}

	public void SetPlayer(Transform trans)
	{
		PlayerTrans = trans;
	}

}
