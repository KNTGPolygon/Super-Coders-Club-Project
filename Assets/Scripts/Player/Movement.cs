using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	[SerializeField] private float playerSpeedPerSecond;

	void Update()
	{
		UpdatedPosition("d", Vector3.right);
		UpdatedPosition("a", Vector3.left);
		UpdatedPosition("w", Vector3.up);
		UpdatedPosition("s", Vector3.down);
	}

	private void UpdatedPosition(string key ,Vector3 moveVector)
	{	
		if (Input.GetKey(key))
		{
			transform.position += moveVector * playerSpeedPerSecond * Time.deltaTime;
		}
	}
}
