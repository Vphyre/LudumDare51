using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBeamController : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private Transform[] lightPoints;
    

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();        
    }
    public void SetUpLine(Transform[] points)
    {
        lineRenderer.positionCount = points.Length;
        lightPoints = points;
    }
    private void Update()
    {
        for (int i = 0; i < lightPoints.Length; i++)
        {
            lineRenderer.SetPosition(i, lightPoints[i].position);
        }
    }
}
