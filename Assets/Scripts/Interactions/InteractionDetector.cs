using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InteractionDetector : MonoBehaviour
{
	private Interactable[] foundInteractions;
	[SerializeField] private ActionCallbacker Actions;
	
	private void Awake()
	{
		int temp = 0;
		var foundObjects = FindObjectsOfType<MonoBehaviour>().OfType<Interactable>();
		foreach (Interactable i in foundObjects)
		{
			foundInteractions[temp] = i;
			i.Actions = this.Actions;
			temp++;
		}
	}

	private void Update()
	{
		Vector2 player = transform.position;
		for (int i = 0; i < foundInteractions.Length; ++i)
		{
			Vector2 obiekt = foundInteractions[i].GetObject().transform.position;
			if (!(Vector2.Distance(player, obiekt) <= 10)) continue;
			Actions.MessageDisplay(foundInteractions[i].Message1());
			if (Input.GetKey("e"))
			{
				foundInteractions[i].Interact();
			}
		}
	}
}
