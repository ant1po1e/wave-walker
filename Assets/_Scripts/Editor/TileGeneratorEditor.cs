using UnityEngine;
c
using UnityEditor;

[CustomEditor(typeof(TileGenerator))]
public class TileGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        TileGenerator generator = (TileGenerator)target;
        if (GUILayout.Button("Generate Tiles"))
        {
            generator.GenerateMap();
        }
    }
}
#endif