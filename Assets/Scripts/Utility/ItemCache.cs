using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
    public static class ItemCache
    {
        private static readonly Dictionary<string, GameObject> _cachedObjectsDic = new Dictionary<string, GameObject>();
        public static GameObject GetCachedObject(string path)
        {
            GameObject rs = null;
            if (_cachedObjectsDic.TryGetValue(path, out GameObject value))
            {
                rs = value;
            }
            else
            {
                rs = Resources.Load<GameObject>(path);
                _cachedObjectsDic.Add(path, rs);
            }
            return rs;

        }
    }
}
