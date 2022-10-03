using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData : MonoBehaviour
{
    [SerializeField] private GameData gameData;

    public void Awake()
    {
        gameData.currentStage = 1;
    }
}
