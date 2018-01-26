
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class Bgsegm
		{

				//
				// C++:  Ptr_BackgroundSubtractorGMG createBackgroundSubtractorGMG(int initializationFrames = 120, double decisionThreshold = 0.8)
				//

				//javadoc: createBackgroundSubtractorGMG(initializationFrames, decisionThreshold)
				public static BackgroundSubtractorGMG createBackgroundSubtractorGMG (int initializationFrames, double decisionThreshold)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BackgroundSubtractorGMG retVal = new BackgroundSubtractorGMG(bgsegm_Bgsegm_createBackgroundSubtractorGMG_10(initializationFrames, decisionThreshold));
        
        return retVal;
#else
						return null;
#endif
				}

				//javadoc: createBackgroundSubtractorGMG()
				public static BackgroundSubtractorGMG createBackgroundSubtractorGMG ()
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BackgroundSubtractorGMG retVal = new BackgroundSubtractorGMG(bgsegm_Bgsegm_createBackgroundSubtractorGMG_11());
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  Ptr_BackgroundSubtractorMOG createBackgroundSubtractorMOG(int history = 200, int nmixtures = 5, double backgroundRatio = 0.7, double noiseSigma = 0)
				//

				//javadoc: createBackgroundSubtractorMOG(history, nmixtures, backgroundRatio, noiseSigma)
				public static BackgroundSubtractorMOG createBackgroundSubtractorMOG (int history, int nmixtures, double backgroundRatio, double noiseSigma)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BackgroundSubtractorMOG retVal = new BackgroundSubtractorMOG(bgsegm_Bgsegm_createBackgroundSubtractorMOG_10(history, nmixtures, backgroundRatio, noiseSigma));
        
        return retVal;
#else
						return null;
#endif
				}

				//javadoc: createBackgroundSubtractorMOG()
				public static BackgroundSubtractorMOG createBackgroundSubtractorMOG ()
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BackgroundSubtractorMOG retVal = new BackgroundSubtractorMOG(bgsegm_Bgsegm_createBackgroundSubtractorMOG_11());
        
        return retVal;
#else
						return null;
#endif
				}


		#if UNITY_IOS && !UNITY_EDITOR
		const string LIBNAME = "__Internal";
		#else
				const string LIBNAME = "opencvforunity";
		#endif


				// C++:  Ptr_BackgroundSubtractorGMG createBackgroundSubtractorGMG(int initializationFrames = 120, double decisionThreshold = 0.8)
				[DllImport(LIBNAME)]
				private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGMG_10 (int initializationFrames, double decisionThreshold);

				[DllImport(LIBNAME)]
				private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGMG_11 ();

				// C++:  Ptr_BackgroundSubtractorMOG createBackgroundSubtractorMOG(int history = 200, int nmixtures = 5, double backgroundRatio = 0.7, double noiseSigma = 0)
				[DllImport(LIBNAME)]
				private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorMOG_10 (int history, int nmixtures, double backgroundRatio, double noiseSigma);

				[DllImport(LIBNAME)]
				private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorMOG_11 ();

		}
}
