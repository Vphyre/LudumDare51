using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove : MonoBehaviour
{
    [SerializeField] private float lightSpeed;
    [SerializeField] private Transform[] point;
    [SerializeField] private Transform destination;
    [SerializeField] private LightBeamController line;
    private void Start()
    {
        line.SetUpLine(point);
    }
    private void Update()
    {
        float step = lightSpeed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, destination.position, step);
    }

}
