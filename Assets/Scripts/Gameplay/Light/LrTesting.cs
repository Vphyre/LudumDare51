using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LrTesting : MonoBehaviour
{
    [SerializeField] private Transform[] point;
    [SerializeField] private LightBeamController line;
    private void Start()
    {
        line.SetUpLine(point); 
    }
}
