using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLose : MonoBehaviour, IEndGame
{

	[SerializeField] private GameObject gameOverObject;

	public void EndGame()
	{
		gameOverObject.SetActive(true);
		this.StartCoroutine(DeathDisplay());
	}

	private IEnumerator DeathDisplay()
	{
		yield return new WaitForSeconds(3);
		Application.LoadLevel(Application.loadedLevel);
	}
}
