using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Interactable
{
	ActionCallbacker Actions { get; set; }
	
	string Message1();
	string Message2();
	void Interact();
	GameObject GetObject();
}
