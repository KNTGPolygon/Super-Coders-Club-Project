using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRotate{
    Vector3 direction { set; }
    void DoRotate();
    void SetSpeed(float speed); //degrees per second
	
}
