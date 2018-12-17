using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionCallbacker : MonoBehaviour
{

	[SerializeField] private MessageHandler mHandler;

	public void MessageDisplay(string tekst)
	{
		mHandler.MessageDisplay(tekst);
	}
}
