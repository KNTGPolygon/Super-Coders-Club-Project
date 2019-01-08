using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(FieldOfView))]
public class FOVvisible : Editor
{
    void OnSceneGUI()
    {
        FieldOfView fov = (FieldOfView)target;
        Handles.color = Color.white;
        Vector3 viewAngleA = fov.DirAngle(-fov.viewAngle / 2);
        Vector3 viewAngleB = fov.DirAngle(fov.viewAngle / 2);
        Handles.DrawWireArc(fov.transform.position, Vector3.back, Vector3.right, 360, fov.viewRadius);
        Handles.DrawLine(fov.transform.position, fov.transform.position + viewAngleA * fov.viewRadius);
        Handles.DrawLine(fov.transform.position, fov.transform.position + viewAngleB * fov.viewRadius);
    }
}
