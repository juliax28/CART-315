using UnityEngine;
using Unity.GraphToolkit.Editor;
using Unity.Editor;

[Serializable]
[Graph(AssetExtension)]

public class DialogueGraph : GraphToolkit
{
    public const string AssetExtension = "dialogueGraph";

   [MenuItem("Assets/Create/Dialogue Graph", false)]
    private static void CreateAssetFile()
    {
        GraphDatabase.PromptInProjectBrowserToCreateNewAsset<DialogueGraph>();
    }

}
