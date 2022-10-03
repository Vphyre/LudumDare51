using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChanger : MonoBehaviour
{
    [SerializeField] private LightBeamController lightBeamController;
    private void OnEnable()
    {
        GameManager.onChangeTime += ChangeColor;
        GameManager.onGameStopped += StopGame;
    }
    private void OnDisable()
    {
        GameManager.onChangeTime -= ChangeColor;
        GameManager.onGameStopped -= StopGame;
    }
    private void ChangeColor()
    {
        lightBeamController.CurrentColor.ChangeColorOnPrism();
        lightBeamController.UpdateColor();
    }
    private void StopGame()
    {
        lightBeamController.transform.parent.gameObject.SetActive(false);
    }
}
