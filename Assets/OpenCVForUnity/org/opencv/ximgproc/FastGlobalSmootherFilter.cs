
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class FastGlobalSmootherFilter
//javadoc: FastGlobalSmootherFilter
		public class FastGlobalSmootherFilter : Algorithm
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_FastGlobalSmootherFilter_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				public FastGlobalSmootherFilter (IntPtr addr) : base(addr)
				{
				}


				//
				// C++:  void filter(Mat src, Mat& dst)
				//

				//javadoc: FastGlobalSmootherFilter::filter(src, dst)
				public  void filter (Mat src, Mat dst)
				{
						ThrowIfDisposed ();
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ximgproc_FastGlobalSmootherFilter_filter_10(nativeObj, src.nativeObj, dst.nativeObj);
        
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


				// C++:  void filter(Mat src, Mat& dst)
				[DllImport(LIBNAME)]
				private static extern void ximgproc_FastGlobalSmootherFilter_filter_10 (IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void ximgproc_FastGlobalSmootherFilter_delete (IntPtr nativeObj);

		}
}
