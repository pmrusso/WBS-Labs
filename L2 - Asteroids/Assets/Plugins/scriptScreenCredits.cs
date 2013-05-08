using UnityEngine;
using System.Collections;

public class scriptScreenCredits : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        // Begin Group at the center of the screen
        GUI.BeginGroup(new Rect(Screen.width / 2f - 150f, Screen.height / 2f - 100f, 320f, 200f));

        // Make a box
        GUI.Box(new Rect(0f, 0f, 320f, 200f), "Credits");

        // Place the credits here
        GUI.Label(new Rect(10f, 40f, 320f, 50f),   "Designer                   Pedro Russo");
        GUI.Label(new Rect(10f, 70f, 320f, 80f),   "Artist                        Pedro Russo");
        GUI.Label(new Rect(10f, 100f, 320f, 110f), "Software Eng.           Pedro Russo & José Correia");
        GUI.Label(new Rect(10f, 130f, 320f, 130f), "Level Designer          Pedro Russo");

        // Place Buttons Here
        if (GUI.Button(new Rect(120f, 165f, 80f, 30f), "Back"))
        {
            Application.LoadLevel("ScreenMainMenu");
        }

        GUI.EndGroup();
    }
}
