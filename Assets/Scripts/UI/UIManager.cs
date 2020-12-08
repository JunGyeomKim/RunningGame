using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;








//すべてのUIを管理する
public class UIManager : MonoBehaviour
{

	private static UIManager instance;
	public static UIManager Instance
	{
		get
		{
			return instance;
		}
	}
	Transform ScoreUI;


	public UILabel GameOver;

	public UILabel RealTime;
	public UILabel Item;

	public UILabel MoveScore;
	public UILabel ItemScore;
	public UILabel FinalScore;

	public UIButton JumpBtn;
	public UIButton RetryBtn;
	public UIButton ExitGame;

	float RealTimeCount;
	float ItemCount;
	float finalScore;
	void Start ()
	{
		instance = this;

		JumpBtn.onClick.Add(new EventDelegate(Onclick_Jump));
		RetryBtn.onClick.Add(new EventDelegate(ReTryBtn));
		ExitGame.onClick.Add(new EventDelegate(ExitGameBtn));


		GameOver =
			transform.
			Find("GameOver").
			Find("GameOverLabel").
			GetComponent<UILabel>();

		ScoreUI = transform.Find("ScoreUI");
	}

	void Update ()
			
	{
		if(GameManager.Instance.IsDie == true)
		{
			return;
		}

		RealTimeScore();
	}

	void RealTimeScore()
	{
		RealTimeCount = GameManager.Instance.intLifeTime;
		RealTime.text = ((int)RealTimeCount).ToString();
	}

	public void ItemScoreFunc()
	{
		ItemCount++;
		Item.text = ItemCount.ToString();
	}


	void Onclick_Jump()
	{
		PlayerController.Instance.PlayerJumpFunc();
	}
	
	public void GameOverUI()
	{
		FinallyScore();
		GameOver.gameObject.SetActive(true);
		Invoke("ScoreUIActive", 2);
		
	}

	void ScoreUIActive()
	{
		ScoreUI.gameObject.SetActive(true);
		MoveScore = transform
			.Find("ScoreUI")
			.Find("Score")
			.Find("MoveScore")
			.GetComponent<UILabel>();

		ItemScore = transform
			.Find("ScoreUI")
			.Find("Score")
			.Find("ItemScore")
			.GetComponent<UILabel>();


	}

	void ReTryBtn()
	{
		SceneManager.LoadScene("Stage_Logo");
	}
	void ExitGameBtn()
	{
		Application.Quit();
	}

	void FinallyScore()
	{
		MoveScore.text = RealTime.text;
		ItemScore.text = ItemCount.ToString();

		finalScore = (int)ItemCount + (int)RealTimeCount;
		FinalScore.text = finalScore.ToString();
	}
	
}
