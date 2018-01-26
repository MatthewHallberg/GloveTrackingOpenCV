#if UNITY_5 && UNITY_IOS
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;
using System.Collections;
using System.IO;

namespace OpenCVForUnity
{
		public class iOS_BuildPostprocessor : MonoBehaviour
		{

				[PostProcessBuild]
				public static void OnPostprocessBuild (BuildTarget buildTarget, string path)
				{
						if (buildTarget == BuildTarget.iOS) {

								#if UNITY_5_0 || UNITY_5_1 || UNITY5_2
								string projPath = path + "/Unity-iPhone.xcodeproj/project.pbxproj";
								#else
								string projPath = PBXProject.GetPBXProjectPath (path);
								#endif
			
								PBXProject proj = new PBXProject ();
								proj.ReadFromString (System.IO.File.ReadAllText (projPath));
					
								string target = proj.TargetGuidByName ("Unity-iPhone");

								// Add our framework directory to the framework include path
								//proj.SetBuildProperty (target, "FRAMEWORK_SEARCH_PATHS", "$(inherited)");
								proj.AddBuildProperty (target, "FRAMEWORK_SEARCH_PATHS", "$(PROJECT_DIR)/Frameworks/OpenCVForUnity/Plugins/iOS");

								File.WriteAllText (projPath, proj.WriteToString ());
						}
				}
		}
}
#endif