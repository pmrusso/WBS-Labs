using UnityEngine;
using System.Collections;
using System;

public class scriptSceneManager : MonoBehaviour
{
    // Inspector Variables
    public float gameTime = 60f;
    public int defaultLives = 3;
    public static int score = 0;
    public static int lives = 3;


    // Private Variables





	// Use this for initialization
	void Start () 
    {
        ResetGameState();
        InvokeRepeating("CountDown",1f,1f);
	}
	
	// Update is called once per frame
	void Update () 
    {
	    // Check if the player is still alive
        if (lives <= 0)
        {
            Application.LoadLevel("ScreenLose");
        }

        if (gameTime <= 0)
        {
            Application.LoadLevel("ScreenWin");
        }
	}

    public void ResetGameState()
    {
        lives = defaultLives;
        score = 0;
    }

    void CountDown()
    {
        if (--gameTime == 0)
        {
            CancelInvoke("CountDown");
        }
    }

    public void AddScore()
    {
        score += 1;
    }

    public void DecreaseLives()
    {
        lives -= 1;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10f, 10f, 100f, 20f), "Score: "+score);
        GUI.Label(new Rect(10f, 25f, 100f, 35f), "Lives: "+lives);
        GUI.Label(new Rect(Screen.width - 75f, 10f, 100f, 20f), "Counter:" + gameTime);
    }
}
