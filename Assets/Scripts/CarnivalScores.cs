using System;
using UnityEngine;
using TMPro;

public class CarnivalScores : MonoBehaviour
{

	[SerializeField]
	private int TeddyBearPointsMin = 2000;

	[SerializeField]
	private GameObject TeddyBear;

	[SerializeField]
	private TextMeshPro plinkoScore;

	public static CarnivalScores Instance;

	private int plinkoPoints;

	void Awake()
	{
		if (Instance == null)
			Instance = this;

		TeddyBear.SetActive(false);
	}

	void OnDestroy()
	{
		if (Instance = this)
			Instance = null;
	}

	// Update is called once per frame
	void Update()
	{
		plinkoScore.text = "Plinko: " + plinkoPoints.ToString("0000");

		if (plinkoPoints >= TeddyBearPointsMin)
		{
			TeddyBear.SetActive(true);
		}
		else
		{
			TeddyBear.SetActive(false);
		}
	}

	public void IncrementPlinkoScore(float points)
	{
		plinkoPoints += (int)points;
	}

	public void ResetPlinkoScore()
	{
		plinkoPoints = 0;
	}
}
