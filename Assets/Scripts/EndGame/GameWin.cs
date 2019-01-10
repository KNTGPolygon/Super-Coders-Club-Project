using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour {

	[SerializeField] private GameObject gameWinObject;
	[SerializeField] private float endGameDelay=5.0f;

	public void EndGame()
	{
		gameWinObject.SetActive(true);
		this.StartCoroutine(WinDisplay());
	}

	private IEnumerator WinDisplay()
	{
		yield return new WaitForSeconds(endGameDelay);
		//Application.LoadLevel(Application.loadedLevel);
	}
}
