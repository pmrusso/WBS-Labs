using UnityEngine;
using System.Collections;

public class step4_uv_offset_scale : MonoBehaviour {

    public int column=16;      // u
    public int row=1;         // v
    public int index = 1;   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        index = index%(column*row);                                 // Modulate (animation Index)
        
        Vector2 size = new Vector2(1.0f / column, 1.0f / row);      // Scale
        Vector2 offset = new Vector2(index * size.x, row);          // Offset

        renderer.material.mainTextureOffset = offset;               // Texture Offset
        renderer.material.mainTextureScale = size;                  // Texture scale
    }
}
