#if UNITY_WSA && (UNITY_5_0 || UNITY_5_1)
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.IO;

namespace OpenCVForUnity
{
		public class WSA_BuildPostprocessor
		{
				[PostProcessBuild]
				public static void OnPostprocessBuild (BuildTarget target, string pathToBuiltProject)
				{
						if (target == BuildTarget.WSAPlayer)
								OnPostprocessBuildWSA (pathToBuiltProject);
				}

				private static void OnPostprocessBuildWSA (string pathToBuiltProject)
				{
						string exportedPath = Path.Combine (pathToBuiltProject, PlayerSettings.productName);

						string[] filesToSearch = new[] {
								"App.cpp",
								"App.xaml.cpp",
								"App.cs",
								"App.xaml.cs",
								"MainPage.xaml.cs",
								PlayerSettings.productName + ".Shared/App.cpp",
								PlayerSettings.productName + ".Shared/App.xaml.cpp",
								PlayerSettings.productName + ".Shared/App.cs",
								PlayerSettings.productName + ".Shared/App.xaml.cs",
								PlayerSettings.productName + ".Shared/MainPage.xaml.cs"
						};

						bool patched = false;
						for (int i = 0; i < filesToSearch.Length; i++) {
								string path = Path.Combine (exportedPath, filesToSearch [i]);
								if (path.Contains (".cpp") && PatchFile (path, "m_AppCallbacks->SetBridge(_bridge);", "m_AppCallbacks->SetBridge(_bridge);\r\n\tm_AppCallbacks->LoadGfxNativePlugin(\"opencvforunity.dll\");")) {
										patched = true;
										break;
								}
								if (path.Contains (".cs") && PatchFile (path, "appCallbacks.SetBridge(_bridge);", "appCallbacks.SetBridge(_bridge);\r\n\t\t\t\tappCallbacks.LoadGfxNativePlugin(\"opencvforunity.dll\");")) {
										patched = true;
										break;
								}
						}

						if (!patched)
								Debug.LogError ("Failed to patch file");
				}

				private static bool PatchFile (string fileName, string targetString, string replacement)
				{
						if (File.Exists (fileName) == false)
								return false;

						string text = File.ReadAllText (fileName);

						if (text.IndexOf (targetString) == -1)
								return false;

						// Already patched ?
						if (text.IndexOf (replacement) != -1)
								return true;

						text = text.Replace (targetString, replacement);

						File.WriteAllText (fileName, text);

						return true;
				}
		}
}
#endif
