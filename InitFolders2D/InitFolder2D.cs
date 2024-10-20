using UnityEditor;
using UnityEngine;
public static class ProjectInitializer2D
{
    [InitializeOnLoadMethod]
    private static void OnProjectLoad()
    {
        CreateFolders();
    }
    private static void CreateFolders()
    {
        string[] folders = new string[] { "Assets/Animations", 
                                            "Assets/Audio", 
                                            "Assets/Materials", 
                                            "Assets/Prefabs",
                                            "Assets/Scripts",
                                            "Assets/Sprites",
                                            "Assets/Textures",
                                            "Assets/TileMaps",
                                            "Assets/UI"};

        foreach (string folder in folders)
        {
            if (!AssetDatabase.IsValidFolder(folder))
            {
                AssetDatabase.CreateFolder("Assets", folder.Split('/')[1]);
            }
        }
        AssetDatabase.Refresh();
    }
}