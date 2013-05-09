using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

public class MakeProjectFolder : MonoBehaviour {
    
    // Generate folders in our project


    // Add Menu Item
    // Generate folders and names from the script
    [MenuItem("Project Tools/Make Folders #&_g")]
    private static void MakeFolder()
    {
        GenerateFolders();
    }

    private static void GenerateFolders()
    {
        string path = Application.dataPath + "/";
       
        Directory.CreateDirectory(path + "Audio");
        Directory.CreateDirectory(path + "Materials");
        Directory.CreateDirectory(path + "Meshes");
        Directory.CreateDirectory(path + "Fonts");
        Directory.CreateDirectory(path + "Textures");
        Directory.CreateDirectory(path + "Resources");
        Directory.CreateDirectory(path + "Scripts");
        Directory.CreateDirectory(path + "Shaders");
        Directory.CreateDirectory(path + "Packages");
        Directory.CreateDirectory(path + "Physics");

        // Refresh the Asset Display
        AssetDatabase.Refresh();
    }

}
