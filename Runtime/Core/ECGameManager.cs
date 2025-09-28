using UnityEngine;
using EClone.Utils;

namespace EClone.Core
{
    public class ECGameManager : MonoBehaviour
    {
        private static ECGameManager _instance;
        public static ECGameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    var go = new GameObject("ECGameManager");
                    _instance = go.AddComponent<ECGameManager>();
                    DontDestroyOnLoad(go);
                }
                return _instance;
            }
        }

        public void Init()
        {
            EClone.Utils.ECLogger.Log("ECGameManager initialized.");
        }
    }
}
