using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBeamController : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private Transform[] lightPoints;
    private ColorController currentColor;
    public ColorController CurrentColor { get => currentColor; set => currentColor = value; }
    [SerializeField] private LightMove lightMove;
    public LightMove LightMove { get => lightMove; set => lightMove = value; }

    private void OnEnable()
    {
        lineRenderer = GetComponent<LineRenderer>();
        currentColor = GetComponent<ColorController>();
        UpdateColor();
        lightMove.MoveStart();
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
    public void UpdateColor()
    {
        lineRenderer.startColor = currentColor.GetColor();
        lineRenderer.endColor = currentColor.GetColor();
    }
}
