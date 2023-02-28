using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public abstract class AClickable : MonoBehaviour
    {
        public List<GameObject> ObjectsToActivate;
        public List<MonoBehaviour> ObjectsToEnable;

        public string Key;
        public List<GameObject> ActivateIfKeyOwned;
        
        public abstract void Click();

        protected void ChangeActivation(bool activate)
        {
            foreach (var obj in ObjectsToActivate)
            {
                obj.SetActive(activate);
            }

            foreach (var obj in ObjectsToEnable)
            {
                obj.enabled = activate;
            }

            if (KeyController.Instance.GetKey(Key))
            {
                foreach (var obj in ActivateIfKeyOwned)
                {
                    obj.SetActive(activate);
                }
            }
        }
    }
}