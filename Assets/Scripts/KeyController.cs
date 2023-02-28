using System.Collections.Generic;

namespace DefaultNamespace
{
    public class KeyController
    {
        private static KeyController _instance;
        
        public static KeyController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KeyController();
                }

                return _instance;
            }
        }
        
        private HashSet<string> _keys = new HashSet<string>();

        public void Activate(string key)
        {
            _keys.Add(key);
        }

        public bool GetKey(string key)
        {
            return _keys.Contains(key);
        }
    }
}