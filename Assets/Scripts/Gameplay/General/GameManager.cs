using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private float timeToChangeGame;
    [SerializeField] private LevelLoader levelLoader;
    public float TimeToChangeGame { get => timeToChangeGame; }
    private float originalTime;
    public float OriginalTime { get => originalTime; }
    public delegate void OnEvent();
    public static OnEvent onChangeTime;
    public static OnEvent onGameStopped;
    private bool stopped;
    private void Awake()
    {
        stopped = false;
        instance = this;
        originalTime = 0;
    }

    void Update()
    {
        if(stopped)
        {
            return;
        }
        originalTime += Time.deltaTime;

        if (originalTime >= timeToChangeGame)
        {
            originalTime = 0;
            Debug.Log("Restou cores");
            onChangeTime?.Invoke();
        }
    }
    public void NextStage()
    {
        levelLoader.NextStage();
    }
    public void StopGame()
    {
        stopped = true;
        onGameStopped?.Invoke();
    }
}
