using UnityEngine;
using System.Collections;

public class step6_2d_array_offset : MonoBehaviour {

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
        int index = (int)(Time.time * framesPerSecond);                // Time control FPS
        index = index % (column * row);                                 // Modulate (animation Index)

        print("Index: "+index);
        Vector2 size = new Vector2(1.0f / column, 1.0f / row);          // Scale

        
        int u = index%column;                                           // u displacement vector
        int v = index/column;                                           // v displacement vector

        print("U: "+u+" V:"+v);
       

        Vector2 offset = new Vector2(u * size.x , (1- size.y) - (v * size.y));              // Offset

        renderer.material.mainTextureOffset = offset;                                       // Texture Offset
        renderer.material.mainTextureScale = size;                                          // Texture scale
    }
}
