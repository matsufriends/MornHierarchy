using UnityEngine;
namespace MornHierarchy {
    public class MornHierarchy : MonoBehaviour {
        [ColorUsage(false)]public Color BackColor;
        public bool ApplyChildren;
        #if UNITY_EDITOR
        private void OnValidate() {
            UnityEditor.EditorApplication.RepaintHierarchyWindow();
        }
        #endif
    }
}