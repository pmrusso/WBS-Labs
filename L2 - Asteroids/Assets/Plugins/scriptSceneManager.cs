using UnityEngine;
using System.Collections;
using System;

public class scriptSceneManager : MonoBehaviour {
    // Inspector Variables
    public float gameTime = 60f;
    public static int score = 0;
    public static int lives = 3;


    // Private Variables





	// Use this for initialization
	void Start () 
    {
        InvokeRepeating("CountDown",1f,1f);
	}
	
	// Update is called once per frame
	void Update () 
    {
        // Print score
        Debug.Log("Score: " + score);
	    
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
        GUI.Label(new Rect(10, 10, 100, 20), "Score: "+score);
        GUI.Label(new Rect(10, 25, 100, 35), "Lives: "+lives);
        GUI.Label(new Rect(Screen.width - 75, 10, 100, 20), "Counter:" + gameTime);
    }
}
