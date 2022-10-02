using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove : MonoBehaviour
{
    [SerializeField] private float lightSpeed;
    [SerializeField] private Transform[] point;
    [SerializeField] private Transform destination;
    public Transform Destination { get => destination; set => destination = value; }
    [SerializeField] private LightBeamController line;
    public LightBeamController LightBeamController { get => line; }
    public void MoveStart()
    {
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
        line.SetUpLine(point);
        InvokeRepeating("Movement", 0f, 0.01f);
    }
    private void Movement()
    {
        float step = lightSpeed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, destination.position, step);
    }

}
