using UnityEngine;
using System.Collections;

public class scriptScreenLoad : MonoBehaviour {
    // Inspector Variable
    public float waitTime = 3f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            Application.LoadLevel("Level_01");
        }
        else StartCoroutine(WaitTime());
	}

    void OnGUI()
    {
        // Make a group on the center of the screen
        GUI.BeginGroup(new Rect(Screen.width / 2 - 100f, Screen.height / 2 - 100f, 200f, 200f));

        // MAke a box to see the group
        GUI.Box(new Rect(0f, 0f, 200f, 200f), "Instructions");

        // Instructions for the player go here
        GUI.Label(new Rect(10f, 30f, 140f, 40f), "Arrow Keys to Move");
        GUI.Label(new Rect(10f, 60f, 160f, 40f),"Spacebar to shoot");
        GUI.Label(new Rect(10f, 90f, 160f, 40f), "ESC to quit the game");

        // End the Group
        GUI.EndGroup();
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(waitTime);
        Application.LoadLevel("Level_01");
    }
}
