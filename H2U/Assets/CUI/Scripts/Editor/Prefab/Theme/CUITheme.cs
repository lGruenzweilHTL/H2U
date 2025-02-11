using UnityEngine;

namespace CUI.Scripts.Editor.Prefab.Theme
{
    [CreateAssetMenu(menuName = "CUI/Theme")]
    public class CUITheme : ScriptableObject
    {
        public int test = -1;

        public static CUITheme DefaultCuiTheme = CreateInstance<CUITheme>();
    }
}