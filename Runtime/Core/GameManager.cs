using UnityEngine;
using EClone.Utils;

namespace EClone.Core
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;
        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    var go = new GameObject("GameManager");
                    _instance = go.AddComponent<GameManager>();
                    DontDestroyOnLoad(go);
                }
                return _instance;
            }
        }

        public void Init()
        {
            EClone.Utils.Logger.Log("GameManager initialized.");
        }
    }
}
