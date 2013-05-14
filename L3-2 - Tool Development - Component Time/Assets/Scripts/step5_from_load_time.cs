using UnityEngine;
using System.Collections;


//  Start time
//  Desc: Start time starts the playTime at zero and stores current time

public class step5_from_load_time : MonoBehaviour
{
    public float playTime       = 0f;
    public float startTime      = 0f;
    public float fromStartTime  = 0f;
    public float fromLoadTime   = 0f;

    public bool timeActive      = true;

	// Use this for initialization
	void Start () {
	  
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (timeActive)                                     // Checks if timer is enabled;
        {
            playTime = Time.time;                           // playTime is current time since start;
        }

        if (Input.GetKeyDown("1"))                          // press a key to activate the start time;
        {
            startTime = Time.time;                          // Start time equals current time;
        }

        fromStartTime = Time.time - startTime;              // counting from start time (starts at zero)

        if (Input.GetKeyDown(KeyCode.Alpha2))               // press key to start time since level load
        {
            fromLoadTime = Time.timeSinceLevelLoad;         // Load time equals original level time
        }

	    
	}

    void OnGUI()
    {
        GUILayout.Label("Playtime: "                +playTime);
        GUILayout.Label("Start Time: "              +startTime);
        GUILayout.Label("Current Game Time: "       +Mathf.FloorToInt(fromStartTime));
        GUILayout.Label("From Load Time: "          +Mathf.FloorToInt(fromLoadTime));
    }
   
}
