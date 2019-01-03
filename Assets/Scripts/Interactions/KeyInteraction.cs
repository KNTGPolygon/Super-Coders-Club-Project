using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInteraction : MonoBehaviour, Interactable {
	public ActionCallbacker Actions { get; set; }

	public string Message1()
	{
		return "Press <color=orange><b>E</b><color=black> to pick up the key\n";
	}

	public string Message2()
	{
		return "";
	}
    
	public void Interact()
	{
		//zwieksz liczbe kluczy
		Destroy(this);
	}
	
	public GameObject GetObject()
	{
		return this.gameObject;
	}
	
}
