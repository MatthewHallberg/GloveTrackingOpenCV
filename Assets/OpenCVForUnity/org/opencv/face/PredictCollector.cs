
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class PredictCollector
//javadoc: PredictCollector
		public class PredictCollector : DisposableOpenCVObject
		{

				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
face_PredictCollector_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				public PredictCollector (IntPtr addr) : base(addr)
				{
				}



				//
				// C++:  bool emit(int label, double dist, int state = 0)
				//

				//javadoc: PredictCollector::emit(label, dist, state)
				public virtual bool emit (int label, double dist, int state)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = face_PredictCollector_emit_10(nativeObj, label, dist, state);
        
        return retVal;
#else
						return false;
#endif
				}

				//javadoc: PredictCollector::emit(label, dist)
				public virtual bool emit (int label, double dist)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = face_PredictCollector_emit_11(nativeObj, label, dist);
        
        return retVal;
#else
						return false;
#endif
				}



				//
				// C++:  void init(int size, int state = 0)
				//

				//javadoc: PredictCollector::init(size, state)
				public  void init (int size, int state)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        face_PredictCollector_init_10(nativeObj, size, state);
        
        return;
#else
						return;
#endif
				}

				//javadoc: PredictCollector::init(size)
				public  void init (int size)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        face_PredictCollector_init_11(nativeObj, size);
        
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


				
				// C++:  bool emit(int label, double dist, int state = 0)
				[DllImport(LIBNAME)]
				private static extern bool face_PredictCollector_emit_10 (IntPtr nativeObj, int label, double dist, int state);

				[DllImport(LIBNAME)]
				private static extern bool face_PredictCollector_emit_11 (IntPtr nativeObj, int label, double dist);

				// C++:  void init(int size, int state = 0)
				[DllImport(LIBNAME)]
				private static extern void face_PredictCollector_init_10 (IntPtr nativeObj, int size, int state);

				[DllImport(LIBNAME)]
				private static extern void face_PredictCollector_init_11 (IntPtr nativeObj, int size);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void face_PredictCollector_delete (IntPtr nativeObj);

		}
}
