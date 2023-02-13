using UnityEditor;
using UnityEngine;

public class EmptySepratorGameObjectCreator : Editor
{

    [MenuItem("Tools/Create Empty Separator")]
    private static void CreatEmptySeperator()
    {
        GameObject sepratorGameObject = new();

        sepratorGameObject.name = "---------------------------------------------------------------------------------------------------";

        sepratorGameObject.transform.position = Vector3.zero;
        sepratorGameObject.transform.localScale = Vector3.zero;
        sepratorGameObject.transform.rotation = Quaternion.identity;

    }
}
