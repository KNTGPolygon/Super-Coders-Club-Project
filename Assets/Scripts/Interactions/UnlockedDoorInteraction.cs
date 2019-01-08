using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedDoorInteractions : MonoBehaviour, Interactable
{

	[SerializeField] private bool _isOpen;
    [SerializeField] private IRotate openingRotation;
    [SerializeField] private IRotate closingRotation;
    public ActionCallbacker Actions { get; set; }
	public void Initialize(bool openStatus=false)
	{
		_isOpen = openStatus;
	}



	public string Message1()
	{
		return _isOpen==false ? "Press <color=orange><b>E</b><color=black> to open the door\n" : "Press <color=orange><b>E</b><color=black> to close the door\n";
	}

	public string Message2()
	{
		return "";
	}

	public void Interact()
	{
		if (_isOpen)
			{
                closingRotation.DoRotate();
				_isOpen = false;
			}
		else
			{
                openingRotation.DoRotate();
				_isOpen = true;
			}
	}

	public GameObject GetObject()
	{
		return this.gameObject;
	}
}
