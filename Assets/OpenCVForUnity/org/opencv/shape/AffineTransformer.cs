
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class AffineTransformer
//javadoc: AffineTransformer
		public class AffineTransformer : ShapeTransformer
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
shape_AffineTransformer_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				public AffineTransformer (IntPtr addr) : base(addr)
				{
				}


				//
				// C++:  bool getFullAffine()
				//

				//javadoc: AffineTransformer::getFullAffine()
				public  bool getFullAffine ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = shape_AffineTransformer_getFullAffine_10(nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}


				//
				// C++:  void setFullAffine(bool fullAffine)
				//

				//javadoc: AffineTransformer::setFullAffine(fullAffine)
				public  void setFullAffine (bool fullAffine)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        shape_AffineTransformer_setFullAffine_10(nativeObj, fullAffine);
        
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


				// C++:  bool getFullAffine()
				[DllImport(LIBNAME)]
				private static extern bool shape_AffineTransformer_getFullAffine_10 (IntPtr nativeObj);

				// C++:  void setFullAffine(bool fullAffine)
				[DllImport(LIBNAME)]
				private static extern void shape_AffineTransformer_setFullAffine_10 (IntPtr nativeObj, bool fullAffine);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void shape_AffineTransformer_delete (IntPtr nativeObj);

		}
}
