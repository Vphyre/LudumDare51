using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private GameData gameData;
    [SerializeField] private string endingSceneName;
    private int stagesAmount;
    private string currentSceneName;
    private void Awake()
    {
        var stages = Resources.LoadAll("Stages/");
        stagesAmount = stages.Length;
        currentSceneName = SceneManager.GetActiveScene().name;
        LoadLevel();
        Time.timeScale = 1f;
    }

    public void NextStage()
    {
        gameData.currentStage++;
        if(gameData.currentStage > stagesAmount)
        {
            gameData.currentStage = 1;
            SceneManager.LoadScene(endingSceneName);
        }
        else
        {
            SceneManager.LoadScene(currentSceneName);
        }
    }
    private void LoadLevel()
    {
        Instantiate(Resources.Load("Stages/Stage " + gameData.currentStage));
    }
}
