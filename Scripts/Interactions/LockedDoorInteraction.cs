using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorInteractions : MonoBehaviour, Interactable {

	[SerializeField] private bool _isOpen;
	private bool _isLocked;

	public ActionCallbacker Actions { get; set; }
	public void Initialize(bool openStatus=false)
    	{
    		_isOpen = openStatus;
		    _isLocked = true;
	    }

	

	public string Message1()
	{
		return _isOpen==false ? "Press <color=orange><b>E</b><color=black> to open the door\n" : "Press <color=orange><b>E</b><color=black> to close the door\n";
	}

	public string Message2()
	{
		return "You cannot open this door, they are locked.\n You need to find a key first\n";
	}

	public void Interact()
	{
		if (_isOpen)
		{
//				Odpal animacje zamykania drzwi
			_isOpen = false;
		}
		else
		{
			if (_isLocked)
			{
//				Sprawdz czy gracz ma klucz, jesli ma zmien status drzwi i zabierz klucz, jesli nie wyswietl Message2
			}
//				Odpal animacje otwierania drzwi
			_isOpen = true;
		}
	}
	
	public GameObject GetObject()
	{
		return this.gameObject;
	}
}
