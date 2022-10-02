using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string currentLevelName = "Test";
    public string mainMenuName = "MainMenu";

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    void OnEnable()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(currentLevelName);
    }

    public void Quit()
    {
        SceneManager.LoadScene(mainMenuName);
    }
}
