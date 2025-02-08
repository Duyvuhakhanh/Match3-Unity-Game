using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Utility
{
    public static class ObjectCache<T> where T : Object
    {
        private static readonly Dictionary<string, T> _cachedObjectsDic = new Dictionary<string, T>();
        public static T GetCachedObject(string path)
        {
            return _cachedObjectsDic.TryGetValue(path, out T rs) ? rs : Resources.Load<T>(path);
        }
    }
}
