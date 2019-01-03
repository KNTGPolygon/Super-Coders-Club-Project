using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRotate : MonoBehaviour, IRotate {

    public Vector3 direction { private get; set; }
    private Coroutine coroutine;
    private float speed=45;
    public void Start()
    {
        direction = Vector3.back;
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public void DoRotate()
    {
        coroutine = this.StartCoroutine(DoingRotate());
    }

    private IEnumerator DoingRotate()
    {
        float timer = 0;
        while (timer < 90/speed)
        {
            transform.Rotate(direction * speed * Time.deltaTime);
            timer += Time.deltaTime;
            yield return null;
        }
    }
}
