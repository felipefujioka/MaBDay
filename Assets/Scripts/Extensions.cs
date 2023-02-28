using UnityEngine;

namespace DefaultNamespace
{
    public static class Extensions
    {
        private static int FloorLayer = LayerMask.NameToLayer("Floor");
        private static int ClickableLayer = LayerMask.NameToLayer("Clickable");
        
        public static bool IsFloor(this RaycastHit hit)
        {
            return hit.collider.gameObject.layer == FloorLayer;
        }
        
        public static bool IsClickable(this RaycastHit hit)
        {
            return hit.collider.gameObject.layer == ClickableLayer;
        }
    }
}