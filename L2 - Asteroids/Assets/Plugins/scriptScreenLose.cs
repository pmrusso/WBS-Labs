using UnityEngine;
using System.Collections;

public class scriptScreenLose : MonoBehaviour
{
    // Inspector Variables
    public string loseQuote = "YOU LOSE!!";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        // Make a Group
        GUI.BeginGroup(new Rect(Screen.width / 2f - 100f, Screen.height / 2f - 100f, 200f, 100f));

        // Make a box to see the group
        GUI.Box(new Rect(0f, 0f, 200f, 100f), loseQuote);

        // Show score
        GUI.Label(new Rect(10f, 30f, 200f, 50f), "Score: "+scriptSceneManager.score);

        // Add Buttons 
        if (GUI.Button(new Rect(60f, 60f, 80f, 30f), "Main Menu"))
        {
            Application.LoadLevel("ScreenMainMenu");
        }

        // End Group
        GUI.EndGroup();

    }
}
