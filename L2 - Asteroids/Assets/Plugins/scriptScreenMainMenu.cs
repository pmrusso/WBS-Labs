using UnityEngine;
using System.Collections;
using System;

public class scriptScreenMainMenu : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        // Make a group on the center of the screen
        GUI.BeginGroup(new Rect(Screen.width / 2 - 50f, Screen.height / 2 - 50f, 100f, 175f));

        // Make a box to see the group on the screen
        GUI.Box(new Rect(0f, 0f, 100f, 175f), "Main Menu");

        // Add Butttons for game navigation
        if (GUI.Button(new Rect(10f, 30f, 80f, 30f), "Start Game"))
        {
            Application.LoadLevel("ScreenLoad");
        }

        if (GUI.Button(new Rect(10f, 65f, 80f, 30f), "Credits"))
        {
            Application.LoadLevel("ScreenCredit");
        }

        if (GUI.Button(new Rect(10f, 100f, 80f, 30f), "Exit"))
        {
            Application.Quit() ;
        }

        if (GUI.Button(new Rect(10f, 135f, 80f, 30f), "Homepage"))
        {
            Application.OpenURL("http://www.gameclubpt.com");
        }


        // End the group
        GUI.EndGroup();

    }
}
