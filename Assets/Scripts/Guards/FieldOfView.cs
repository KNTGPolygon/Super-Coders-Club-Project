using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float viewRadius;
    public float viewAngle;
    private float lineWidth = 0.2f;
    private int vertexCount = 100;
    Transform player;
    
    private LineRenderer lineRenderer;
 
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        SetupCircle();
    }
 
    private void SetupCircle()
    {
        float radius = viewRadius;
        lineRenderer.widthMultiplier = lineWidth;
 
        float deltaTheta = (2f * Mathf.PI) / vertexCount;
        float theta = 0f;
 
        lineRenderer.positionCount = vertexCount;
        for (int i=0; i<lineRenderer.positionCount; i++)
        {
            Vector3 pos = new Vector3(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta), 0f);
            lineRenderer.SetPosition(i, pos);
            theta += deltaTheta;
        }
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (PlayerInFOV())
        {
            GetComponent<IEndGame>().EndGame();
            
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
