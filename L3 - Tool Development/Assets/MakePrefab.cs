using UnityEngine;
using System.Collections;
using UnityEditor;

public class MakePrefab : MonoBehaviour {

	[MenuItem("Project Tools/Make Prefab")]
	static void CreatePrefab()
	{

	    GameObject[] selectedObject = Selection.gameObjects;

        Debug.Log("será aqui");
        foreach (GameObject go in selectedObject)
        {
            string path = "Assets/" + go.name + ".prefab";
            if (AssetDatabase.LoadAssetAtPath(path, typeof(GameObject)))
            {
                Debug.Log("aqui");
                if (EditorUtility.DisplayDialog("Are you sure?",
                                                "The prefab already exists. Do you want to overwrite it?", "Yes", "No"))
                {
                    CreateNew(go, path);    
                }

            }
            else CreateNew(go, path);
        }
        AssetDatabase.Refresh();
        
	}

    static void CreateNew(GameObject obj, string path)
    {
        Debug.Log("e agora aqui");
        Object prefab = PrefabUtility.CreateEmptyPrefab(path);
        PrefabUtility.ReplacePrefab(obj, prefab, ReplacePrefabOptions.ConnectToPrefab);
    }
}
