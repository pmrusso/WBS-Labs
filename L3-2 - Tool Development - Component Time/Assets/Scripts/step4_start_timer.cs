using UnityEngine;
using System.Collections;


//  Start time
//  Desc: Start time starts the playTime at zero and stores current time

public class step4_start_timer : MonoBehaviour
{
    public float playTime       = 0f;
    public float startTime      = 0f;
    public float fromStartTime  = 0f;

    public bool timeActive      = true;

	// Use this for initialization
	void Start () {
	  
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (timeActive)
        {
            playTime = Time.time;       // playTime = currentTime
        }
	    
        if (Input.GetKey("1"))
        {
            startTime = Time.time;      // press a key to activate the start time
        }

	    fromStartTime = Time.time - startTime;

	    // counting from start time
	}

    void OnGUI()
    {
        GUILayout.Label("Playtime: "                +playTime);
        GUILayout.Label("Start Time: "              +startTime);
        GUILayout.Label("Current Game Time: "       +Mathf.FloorToInt(fromStartTime));
    }
   
}
