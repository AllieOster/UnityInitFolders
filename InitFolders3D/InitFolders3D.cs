using UnityEditor;
using UnityEngine;
public static class ProjectInitializer3D
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
                                            "Assets/Models", 
                                            "Assets/Prefabs",
                                            "Assets/Scripts",
                                            "Assets/Shaders",
                                            "Assets/Textures",
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