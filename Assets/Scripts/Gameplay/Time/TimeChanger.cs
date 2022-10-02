using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChanger : MonoBehaviour
{
    [SerializeField] private LightBeamController lightBeamController;
    private void OnEnable()
    {
        GameManager.onChangeTime += ChangeColor;
    }
    private void OnDisable()
    {
        GameManager.onChangeTime -= ChangeColor;
    }
    private void ChangeColor()
    {
        lightBeamController.CurrentColor.ChangeColorOnPrism();
        lightBeamController.UpdateColor();
    }
}
