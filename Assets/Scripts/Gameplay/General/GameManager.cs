using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private float timeToChangeGame;
    public float TimeToChangeGame { get => timeToChangeGame; }
    private float originalTime;
    public delegate void OnEvent();
    public static OnEvent onChangeTime;
    private void Awake()
    {
        instance = this;
        originalTime = 0;
    }

    void Update()
    {
        originalTime += Time.deltaTime;
        if (originalTime >= timeToChangeGame)
        {
            originalTime = 0;
            Debug.Log("Restou cores");
            onChangeTime?.Invoke();
        }
    }
}
