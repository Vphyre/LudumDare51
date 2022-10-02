using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    public GameManager gameManager;
    public int limitTime = 60;
    public GameObject gameOverScreen;
    private Text txtTimeLeft;
    private int timeLeft = 0;
    private float elapsedTime = 0f;
    private Text txtTimeToChange;
    private int timeToChange = 0;

    // Start is called before the first frame update
    void OnEnable()
    {
        txtTimeLeft = GameObject.Find("txtTimeLeft").GetComponent<Text>();
        txtTimeToChange = GameObject.Find("txtTimeToChange").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeToChange = (int) (gameManager.TimeToChangeGame - gameManager.OriginalTime);
        txtTimeToChange.text = timeToChange.ToString();

        elapsedTime += Time.deltaTime;
        timeLeft = (int)(limitTime - elapsedTime);
        txtTimeLeft.text = timeLeft.ToString();

        if (timeLeft == 0)
        {
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
        }
    }
}
