using UnityEngine;
using System.Collections;

public class step10_using_aniSprite : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    AniSprite aniPlay = GetComponent<AniSprite>();

	    if (Input.GetKey(KeyCode.D))
	    {
	        aniPlay.AnimateSprite(8, 2, 0, 0, 16, 16);
	    }
	}
}
