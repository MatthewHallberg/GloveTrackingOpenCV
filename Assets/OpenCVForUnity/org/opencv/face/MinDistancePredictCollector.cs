
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class MinDistancePredictCollector
//javadoc: MinDistancePredictCollector
		public class MinDistancePredictCollector : PredictCollector
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
face_MinDistancePredictCollector_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				protected MinDistancePredictCollector (IntPtr addr) : base(addr)
				{
				}


				//
				// C++:   MinDistancePredictCollector(double threshold = DBL_MAX)
				//

				//javadoc: MinDistancePredictCollector::MinDistancePredictCollector(threshold)
				public   MinDistancePredictCollector (double threshold)
    :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        base( face_MinDistancePredictCollector_MinDistancePredictCollector_10(threshold) )
        
        
#else
				base(IntPtr.Zero)
#endif
				{
						return;
				}

				//javadoc: MinDistancePredictCollector::MinDistancePredictCollector()
				public   MinDistancePredictCollector ()
    :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
				base( face_MinDistancePredictCollector_MinDistancePredictCollector_11() )
        
        
#else
				base(IntPtr.Zero)
#endif
				{
						return;
				}


				//
				// C++: static Ptr_MinDistancePredictCollector create(double threshold = DBL_MAX)
				//

				//javadoc: MinDistancePredictCollector::create(threshold)
				public static MinDistancePredictCollector create (double threshold)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        MinDistancePredictCollector retVal = new MinDistancePredictCollector(face_MinDistancePredictCollector_create_10(threshold));
        
        return retVal;
#else
						return null;
#endif
				}

				//javadoc: MinDistancePredictCollector::create()
				public static MinDistancePredictCollector create ()
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        MinDistancePredictCollector retVal = new MinDistancePredictCollector(face_MinDistancePredictCollector_create_11());
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  bool emit(int label, double dist, int state = 0)
				//

				//javadoc: MinDistancePredictCollector::emit(label, dist, state)
				public override bool emit (int label, double dist, int state)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = face_MinDistancePredictCollector_emit_10(nativeObj, label, dist, state);
        
        return retVal;
#else
						return false;
#endif
				}

				//javadoc: MinDistancePredictCollector::emit(label, dist)
				public override bool emit (int label, double dist)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = face_MinDistancePredictCollector_emit_11(nativeObj, label, dist);
        
        return retVal;
#else
						return false;
#endif
				}



				//
				// C++:  double getDist()
				//

				//javadoc: MinDistancePredictCollector::getDist()
				public  double getDist ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double retVal = face_MinDistancePredictCollector_getDist_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  int getLabel()
				//

				//javadoc: MinDistancePredictCollector::getLabel()
				public  int getLabel ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = face_MinDistancePredictCollector_getLabel_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


    

		#if UNITY_IOS && !UNITY_EDITOR
		const string LIBNAME = "__Internal";
		#else
				const string LIBNAME = "opencvforunity";
		#endif

				// C++:   MinDistancePredictCollector(double threshold = DBL_MAX)
				[DllImport(LIBNAME)]
				private static extern IntPtr face_MinDistancePredictCollector_MinDistancePredictCollector_10 (double threshold);

				[DllImport(LIBNAME)]
				private static extern IntPtr face_MinDistancePredictCollector_MinDistancePredictCollector_11 ();

				// C++: static Ptr_MinDistancePredictCollector create(double threshold = DBL_MAX)
				[DllImport(LIBNAME)]
				private static extern IntPtr face_MinDistancePredictCollector_create_10 (double threshold);

				[DllImport(LIBNAME)]
				private static extern IntPtr face_MinDistancePredictCollector_create_11 ();

				// C++:  bool emit(int label, double dist, int state = 0)
				[DllImport(LIBNAME)]
				private static extern bool face_MinDistancePredictCollector_emit_10 (IntPtr nativeObj, int label, double dist, int state);

				[DllImport(LIBNAME)]
				private static extern bool face_MinDistancePredictCollector_emit_11 (IntPtr nativeObj, int label, double dist);

				// C++:  double getDist()
				[DllImport(LIBNAME)]
				private static extern double face_MinDistancePredictCollector_getDist_10 (IntPtr nativeObj);

				// C++:  int getLabel()
				[DllImport(LIBNAME)]
				private static extern int face_MinDistancePredictCollector_getLabel_10 (IntPtr nativeObj);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void face_MinDistancePredictCollector_delete (IntPtr nativeObj);

		}
}
