using UnityEngine;
using UnityEditor;

public class UIConverterEditorWindow : EditorWindow {
    private int insertionMethod;
    private GameObject insertionObject;
    private string htmlCode = "!<DOCTYPE html>\n<html>\n\t<head>\n\t\t<title>\n\t\t\tPage Title\n\t\t</title>\n\t</head>\n<body>\n\n</body>\n</html>".Replace("\t", "    ");

    [MenuItem("H2U/UIConverterWindow")]
    private static void ShowWindow() {
        var window = GetWindow<UIConverterEditorWindow>();
        window.titleContent = new GUIContent("UI Converter");
        window.minSize = new Vector2(600, 400);
        window.Show();
    }

    private void OnGUI() {
        EditorGUILayout.LabelField("HTML to Unity UI Converter");

        // HTML code input
        EditorGUILayout.LabelField("HTML code:");
        htmlCode = EditorGUILayout.TextArea(htmlCode, GUILayout.Height(200));

        // Insertion method selection
        EditorGUILayout.LabelField("Insertion method:");
        insertionMethod = EditorGUILayout.Popup(insertionMethod, new string[] { "Root", "Child of current Selection", "Sibling of current Selection", "Child of GameObject" });

        // Insertion object selection
        if (insertionMethod == 0) {
            insertionObject = null;
        } else if (insertionMethod == 1) {
            insertionObject = Selection.activeGameObject;
        } else if (insertionMethod == 2) {
            insertionObject = Selection.activeGameObject?.transform?.parent?.gameObject;
        } else if (insertionMethod == 3) {
            insertionObject = (GameObject)EditorGUILayout.ObjectField(insertionObject, typeof(GameObject), true);
        }

        // Convert button
        if (GUILayout.Button("Convert")) {
            // do something
            Debug.Log("Convert button clicked: " + htmlCode);
        }
    }
}