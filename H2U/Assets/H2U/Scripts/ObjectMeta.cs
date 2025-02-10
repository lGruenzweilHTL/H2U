using System.Collections.Generic;
using UnityEngine;

namespace H2U.Scripts
{
    public class ObjectMeta : MonoBehaviour
    {
        public string Name;
        public string Id;
        public string InnerText;
        public Dictionary<string, string> Attributes;
        
        public void SetContents(HTMLElement elm)
        {
            
        }
    }
}