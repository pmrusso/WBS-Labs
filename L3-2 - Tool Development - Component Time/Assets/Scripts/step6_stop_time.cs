using UnityEngine;
using System.Collections;


//  Start time
//  Desc: Start time starts the playTime at zero and stores current time

public class step6_stop_time : MonoBehaviour
{
    public float playTime       = 0f;
    public float stopTime       = 0f;
    public float pauseGameTime  = 0f;
  
    public bool timeActive      = true;

	// Use this for initialization
	void Start () {
	  
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (timeActive)                                                         // Checks if timer is enabled;
        {
            playTime = Time.time - pauseGameTime;                               // playTime is current time since start;
        }

	    if (Input.GetKeyDown("3"))                                              // press a key to activate the stop/start time;
        {
            timeActive = !timeActive;
            if (!timeActive)
                stopTime = Time.time;
            else
            {
                timeActive = true;
                pauseGameTime += Time.time - stopTime;
                print("playtime: " + Time.time + " stopTime: " + stopTime); 
            }
        }
	    if (Input.GetKeyDown("4"))                                              // press to halt the Time.time variable
	    {
	        Time.timeScale = 0.0f;
	    }
        else if (Input.GetKeyUp("4"))                                           // release to allow the passing of time
        {
            Time.timeScale = 1.0f;
        }
	}

    void OnGUI()
    {
        GUILayout.Label("Playtime: "                    +playTime);
        GUILayout.Label("stoptime: "                    +stopTime);
        GUILayout.Label("pauseGameTime: "               +pauseGameTime);

    }
   
}
