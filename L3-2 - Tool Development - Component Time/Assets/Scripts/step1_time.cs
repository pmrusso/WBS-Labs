using UnityEngine;
using System.Collections;

public class step1_time : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    
	    if (Input.GetKeyDown("a"))
        {
            print(Time.time);
        }
	}
}
