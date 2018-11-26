using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    private float score = 0f;
    private float lives = 1;
    public Text scoreText;
    public Text livesText;
    public GameObject gameOverUI;

    public void ScoreIncrement()
    {
        score = score + 1;
        scoreText.text = score.ToString();
    }

    public void LifeDecrement()
    {
        lives = lives - 1;
        livesText.text = lives.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (lives == 0)
        {
            gameOverUI.SetActive(true);
            Invoke("RestartGame", 3f);
        }
	}
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
