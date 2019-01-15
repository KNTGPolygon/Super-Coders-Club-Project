using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AreaCheck : MonoBehaviour
{

	private void OnTriggerEnter2D(Collider2D other)
	{
		GetComponent<IEndGame>().EndGame();
	}
}
