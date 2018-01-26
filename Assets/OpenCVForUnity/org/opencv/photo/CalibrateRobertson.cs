
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class CalibrateRobertson
//javadoc: CalibrateRobertson
		public class CalibrateRobertson : CalibrateCRF
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
photo_CalibrateRobertson_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				public CalibrateRobertson (IntPtr addr) : base(addr)
				{
				}


				//
				// C++:  Mat getRadiance()
				//

				//javadoc: CalibrateRobertson::getRadiance()
				public  Mat getRadiance ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Mat retVal = new Mat(photo_CalibrateRobertson_getRadiance_10(nativeObj));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  float getThreshold()
				//

				//javadoc: CalibrateRobertson::getThreshold()
				public  float getThreshold ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        float retVal = photo_CalibrateRobertson_getThreshold_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  int getMaxIter()
				//

				//javadoc: CalibrateRobertson::getMaxIter()
				public  int getMaxIter ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = photo_CalibrateRobertson_getMaxIter_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  void setMaxIter(int max_iter)
				//

				//javadoc: CalibrateRobertson::setMaxIter(max_iter)
				public  void setMaxIter (int max_iter)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        photo_CalibrateRobertson_setMaxIter_10(nativeObj, max_iter);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setThreshold(float threshold)
				//

				//javadoc: CalibrateRobertson::setThreshold(threshold)
				public  void setThreshold (float threshold)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        photo_CalibrateRobertson_setThreshold_10(nativeObj, threshold);
        
        return;
#else
						return;
#endif
				}


    
		#if UNITY_IOS && !UNITY_EDITOR
		const string LIBNAME = "__Internal";
		#else
				const string LIBNAME = "opencvforunity";
		#endif


				// C++:  Mat getRadiance()
				[DllImport(LIBNAME)]
				private static extern IntPtr photo_CalibrateRobertson_getRadiance_10 (IntPtr nativeObj);

				// C++:  float getThreshold()
				[DllImport(LIBNAME)]
				private static extern float photo_CalibrateRobertson_getThreshold_10 (IntPtr nativeObj);

				// C++:  int getMaxIter()
				[DllImport(LIBNAME)]
				private static extern int photo_CalibrateRobertson_getMaxIter_10 (IntPtr nativeObj);

				// C++:  void setMaxIter(int max_iter)
				[DllImport(LIBNAME)]
				private static extern void photo_CalibrateRobertson_setMaxIter_10 (IntPtr nativeObj, int max_iter);

				// C++:  void setThreshold(float threshold)
				[DllImport(LIBNAME)]
				private static extern void photo_CalibrateRobertson_setThreshold_10 (IntPtr nativeObj, float threshold);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void photo_CalibrateRobertson_delete (IntPtr nativeObj);

		}
}
