using UnityEngine;
using System.Collections;

public class step5_uv_offset_scale_fps : MonoBehaviour {

    public int column;                      // u
    public int row;                         // v
    public int framesPerSecond = 16;         // fps
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int index = (int) (Time.time * framesPerSecond);                // Time control FPS
        index = index % (column * row);                                 // Modulate (animation Index)

        Vector2 size = new Vector2(1.0f / column, 1.0f / row);          // Scale
        Vector2 offset = new Vector2(index * size.x, row);              // Offset

        renderer.material.mainTextureOffset = offset;                   // Texture Offset
        renderer.material.mainTextureScale = size;                      // Texture scale
    }
}
