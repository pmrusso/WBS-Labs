using UnityEngine;
using System.Collections;

public class step2_min_sec_frac : MonoBehaviour
{
    public float playTime          = 0f;
    public float days              = 0f;
    public float hours             = 0f;
    public float minutes           = 0f;
    public float seconds           = 0f;
    public float fractions         = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    playTime        = Time.time;
	    seconds         = playTime%60;
	    minutes         = (playTime/60) % 60;
	    hours           = (playTime/3600)%24;
	    days            = hours/24;
	    fractions       = (playTime*10)%10;
	}
}
