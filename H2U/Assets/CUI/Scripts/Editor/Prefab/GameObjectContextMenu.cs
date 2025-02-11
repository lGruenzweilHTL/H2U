using CUI.Scripts.Editor.Prefab.Theme;
using CUI.Scripts.Editor.Prefab.Util;
using UnityEditor;
using UnityEngine;

namespace CUI.Scripts.Editor.Prefab
{
    public static class GameObjectContextMenu
    {
        [MenuItem("GameObject/CUI/Interface")]
        public static void CreateInterface()
        {
            InterfaceCreationEditorWindow.ShowWindow();
        }
    }

    public class InterfaceCreationEditorWindow : EditorWindow
    {
        private string _interfaceName = "Interface";
        private int _width = 600;
        private int _height = 200;
        private CUITheme _theme = CUITheme.DefaultCuiTheme;

        private void OnGUI()
        {
            _interfaceName = EditorGUILayout.TextField("Interface Name", _interfaceName);
            _width = EditorGUILayout.IntField("Width", _width);
            _height = EditorGUILayout.IntField("Height", _height);
            
            EditorGUILayout.PrefixLabel("Theme");
            _theme = (CUITheme) EditorGUILayout.ObjectField(_theme, typeof(CUITheme), false);

            if (!_theme)
            {
                EditorGUILayout.HelpBox("Please set a Theme!", MessageType.Error);
                return;
            }
                
            if (!GUILayout.Button("Insert")) return;
            var go = new GameObject(_interfaceName);
            CreateUtility.PlaceObject(go);
            Close();
        }

        public static void ShowWindow()
        {
            var window = GetWindow<InterfaceCreationEditorWindow>();
            window.titleContent = new GUIContent("Interface Creation");
            window.minSize = new Vector2(600, 400);
            var position = window.position;
            position.center = EditorGUIUtility.GetMainWindowPosition().center;
            window.position = position;
            window.Show();
        }
    }
}