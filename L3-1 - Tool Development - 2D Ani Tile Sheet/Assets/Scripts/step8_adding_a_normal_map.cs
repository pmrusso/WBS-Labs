using UnityEngine;
using System.Collections;

public class step8_adding_a_normal_map : MonoBehaviour {

    public int columnSize;                      // u
    public int rowSize;                         // v
    public int framesPerSecond = 16;         // fps

    public int rowFrameStart = 0;
    public int colFrameStart = 0;
    public int totalFrames = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int index = (int)(Time.time * framesPerSecond);                // Time control FPS
        //index = index % (columnSize * rowSize);                                 // Modulate (animation Index)
        index = index % totalFrames;

        //print("Index: " + index);
        Vector2 size = new Vector2(1.0f / columnSize, 1.0f / rowSize);          // Scale


        int u = index % columnSize;                                           // u displacement vector
        int v = index / columnSize;                                           // v displacement vector

        //print("U: " + u + " V:" + v);


        //Vector2 offset = new Vector2(u * size.x, (1 - size.y) - (v * size.y));              // Offset
        Vector2 offset = new Vector2((u + colFrameStart) * size.x, (1 - size.y) - ((v + rowFrameStart) * size.y));              // Offset

        renderer.material.mainTextureOffset = offset;                                       // Texture Offset
        renderer.material.mainTextureScale = size;                                          // Texture scale

        renderer.material.SetTextureOffset("_BumpMap", offset);
        renderer.material.SetTextureScale("_BumpMap", size);
    }
}
