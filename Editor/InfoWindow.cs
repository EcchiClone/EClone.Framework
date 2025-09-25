using UnityEditor;
using UnityEngine;

namespace EClone.Editor
{
    public class InfoWindow : EditorWindow
    {
        [MenuItem("Tools/EClone Framework/Info")]
        private static void OpenWindow()
        {
            var window = GetWindow<InfoWindow>();
            window.titleContent = new GUIContent("EClone Framework");
            window.Show();
        }

        private void OnGUI()
        {
            GUILayout.Label("EClone Framework", EditorStyles.boldLabel);
            GUILayout.Space(5);

            GUILayout.Label("공통 매니저 및 유틸리티 패키지", EditorStyles.wordWrappedLabel);
            GUILayout.Label("Version: 0.1.0", EditorStyles.miniLabel);

            GUILayout.Space(10);

            if (GUILayout.Button("GitHub Repository"))
            {
                Application.OpenURL("https://github.com/EcchiClone/EClone.Framework");
            }
        }
    }
}
