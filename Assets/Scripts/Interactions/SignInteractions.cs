using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignInteractions : MonoBehaviour, Interactable
{

	[SerializeField] private TextAsset tekst;
	public ActionCallbacker Actions { get; set; }
	public void Interact()
	{
		string message = tekst.ToString();
		Actions.MessageDisplay(message);
	}



	public string Message1()
	{
		return "Press <color=orange><b>E</b><color=black> to read the poster\n";
	}

	public string Message2()
	{
		return "";
	}
	
	public GameObject GetObject()
	{
		return this.gameObject;
	}
}
