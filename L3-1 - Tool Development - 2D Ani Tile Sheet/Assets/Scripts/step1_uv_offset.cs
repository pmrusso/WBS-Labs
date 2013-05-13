using UnityEngine;
using System.Collections;

public class step1_uv_offset : MonoBehaviour {
    // Inspector properties
    public float scrollSpeed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float offset = Time.time*scrollSpeed;
        //print(Time.time);
        renderer.material.mainTextureOffset = new Vector2(offset, 0);
        //print("offset Amount: "+offset);
	}
}
