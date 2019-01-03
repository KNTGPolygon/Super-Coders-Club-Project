using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class MessageHandler : MonoBehaviour
{

	[SerializeField] private GameObject MessageText;
	[SerializeField] private float MaxTime;
	private Coroutine coroutine;
	private float time = 0;
	
	public void MessageDisplay(string tekst)
	{
		coroutine = StartCoroutine(DoDisplay(tekst));
	}

	private IEnumerator DoDisplay(string tekst)
	{
		time = 0;
		//ustaw tekst jako wiadomosc MessageText'a
		gameObject.SetActive(MessageText);
		while (time < MaxTime)
		{
			yield return null;
		}
		gameObject.SetActive(MessageText);
		time = 0;
	}
}
