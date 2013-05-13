using UnityEngine;
using System.Collections;

public class step3_uv_row_column : MonoBehaviour
{
    public int tileX; // u
    public int tileY; // v

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    renderer.material.mainTextureOffset = new Vector2(0.25f, 0f);

        Vector2 size = new Vector2(1.0f / tileX, 1.0f / tileY);

	    renderer.material.mainTextureScale = size;

	    print(size);
	}
}
