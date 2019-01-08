using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour
{

    // FSM related variables
    private Animator animator;
    bool waiting = false;
    private float approxTime;

    // Where is it going and how fast?
    Vector3 direction;
    [SerializeField] private float walkSpeed = 20f;
    int currentTarget=-1;
    [SerializeField] private Transform[] waypoints = null;

    // This runs when the guard is added to the scene
    private void Awake()
    {
         // Get a reference to the FSM (animator)
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        // Unless the guard is waiting then move
        if (!waiting)
        {
            transform.Translate(walkSpeed * direction * Time.deltaTime, Space.World);
            approxTime -= Time.deltaTime;
            animator.SetFloat("approxTime", approxTime);
        }

    }

    public void SetNextPoint()
    {
        //Pick next Waypoint
        int nextPoint = (currentTarget+1)%waypoints.Length;
        currentTarget = nextPoint;

        // Load the direction of the next waypoint
        direction = waypoints[currentTarget].position - transform.position;
        rotateGuard();
        approxTime = Vector3.Distance(waypoints[currentTarget].position, transform.position) / walkSpeed;
    }

    private void rotateGuard()
    {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        direction = direction.normalized;
    }

    public void ToggleWaiting()
    {
        waiting = !waiting;
    }
}
