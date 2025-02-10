using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace H2U.Scripts
{
    public class HTMLElement
    {
        public string Name;
        public string Id;
        public string InnerText;
        public Dictionary<string, string> Attributes;
        public List<HTMLElement> Children;

        public GameObject ConvertToGameObject()
        {
            var objects = Children.Select(child => child.ConvertToGameObject()).ToList();
            var go = new GameObject(Name);
            
            var comp = go.AddComponent<ObjectMeta>();
            comp.SetContents(this);
            
            foreach (var obj in objects)
            {
                obj.transform.SetParent(go.transform);
            }

            return go;
        }
    }
}