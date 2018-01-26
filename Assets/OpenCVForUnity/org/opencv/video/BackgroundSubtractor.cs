
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class BackgroundSubtractor
//javadoc: BackgroundSubtractor
		public class BackgroundSubtractor : Algorithm
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
video_BackgroundSubtractor_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				protected BackgroundSubtractor (IntPtr addr) : base(addr)
				{
				}


				//
				// C++:  void apply(Mat image, Mat& fgmask, double learningRate = -1)
				//

				//javadoc: BackgroundSubtractor::apply(image, fgmask, learningRate)
				public  void apply (Mat image, Mat fgmask, double learningRate)
				{
						ThrowIfDisposed ();
						if (image != null)
								image.ThrowIfDisposed ();
						if (fgmask != null)
								fgmask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        video_BackgroundSubtractor_apply_10(nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);
        
        return;
#else
						return;
#endif
				}

				//javadoc: BackgroundSubtractor::apply(image, fgmask)
				public  void apply (Mat image, Mat fgmask)
				{
						ThrowIfDisposed ();
						if (image != null)
								image.ThrowIfDisposed ();
						if (fgmask != null)
								fgmask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        video_BackgroundSubtractor_apply_11(nativeObj, image.nativeObj, fgmask.nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void getBackgroundImage(Mat& backgroundImage)
				//

				//javadoc: BackgroundSubtractor::getBackgroundImage(backgroundImage)
				public  void getBackgroundImage (Mat backgroundImage)
				{
						ThrowIfDisposed ();
						if (backgroundImage != null)
								backgroundImage.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        video_BackgroundSubtractor_getBackgroundImage_10(nativeObj, backgroundImage.nativeObj);
        
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


				// C++:  void apply(Mat image, Mat& fgmask, double learningRate = -1)
				[DllImport(LIBNAME)]
				private static extern void video_BackgroundSubtractor_apply_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);

				[DllImport(LIBNAME)]
				private static extern void video_BackgroundSubtractor_apply_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

				// C++:  void getBackgroundImage(Mat& backgroundImage)
				[DllImport(LIBNAME)]
				private static extern void video_BackgroundSubtractor_getBackgroundImage_10 (IntPtr nativeObj, IntPtr backgroundImage_nativeObj);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void video_BackgroundSubtractor_delete (IntPtr nativeObj);

		}
}
