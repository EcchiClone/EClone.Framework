using UnityEngine;

namespace EClone.Utils
{
    public static class Logger
    {
        public static void Log(string msg)
        {
#if UNITY_EDITOR
            Debug.Log($"[EClone] {msg}");
#else
            Debug.Log(msg);
#endif
        }
    }
}
