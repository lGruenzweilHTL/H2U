using UnityEditor;
using UnityEngine;

namespace CUI.Scripts.Editor.Prefab.Util
{
    public static class CreateUtility
    {
        public static void PlaceObject(GameObject obj)
        {
            var active = Selection.activeGameObject;
            if (active) obj.transform.SetParent(active.transform);
        }
    }
}