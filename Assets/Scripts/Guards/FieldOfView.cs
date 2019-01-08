using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float viewRadius;
    public float viewAngle;
    Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (PlayerInFOV())
        {
            print("Widze cie!"); //tymczasowo, dopóki nie ma end screena
        }
    }

    bool IsPlayerInRadius()
    {
        float distancePlayer = Vector3.Distance(player.position, transform.position);
        return distancePlayer <= viewRadius;
    }

    bool PlayerInFOV()
    {
        Vector3 dirPlayer = player.position - transform.position;
        Debug.DrawLine(transform.position, player.position, Color.magenta);
        float angleGuardPlayer = Vector3.Angle(dirPlayer, transform.up);
        if (angleGuardPlayer <= viewAngle / 2f && IsPlayerInRadius())
        {
            return true;
        }
        return false;
    }

    bool PlayerVisible()
    {

        return false;//tu będzie kod odpowiedzialny za raytracing i rozpoznawanie, czy gracz jest za obiektem
    }

    public Vector3 DirAngle(float angleInDegrees)
    {
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), Mathf.Cos(angleInDegrees * Mathf.Deg2Rad), 0);
    }
}
