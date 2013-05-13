using UnityEngine;
using System.Collections;

public class step2_uv_scale : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float scaleX = 0.0625f;
	    float scaleY = 1f;
        renderer.material.mainTextureOffset = new Vector2(0.25f,0f);
        renderer.material.mainTextureScale = new Vector2(scaleX, scaleY);
	}
}
