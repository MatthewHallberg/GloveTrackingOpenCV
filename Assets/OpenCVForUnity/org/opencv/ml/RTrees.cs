
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class RTrees
//javadoc: RTrees
		public class RTrees : DTrees
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ml_RTrees_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				protected RTrees (IntPtr addr) : base(addr)
				{
				}


				//
				// C++:  Mat getVarImportance()
				//

				//javadoc: RTrees::getVarImportance()
				public  Mat getVarImportance ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Mat retVal = new Mat(ml_RTrees_getVarImportance_10(nativeObj));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++: static Ptr_RTrees create()
				//

				//javadoc: RTrees::create()
#pragma warning disable 0108
				public static RTrees create ()
				{
#pragma warning restore 0067
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        RTrees retVal = new RTrees(ml_RTrees_create_10());
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  TermCriteria getTermCriteria()
				//

				//javadoc: RTrees::getTermCriteria()
				public  TermCriteria getTermCriteria ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double[] tmpArray = new double[3];
			ml_RTrees_getTermCriteria_10 (nativeObj, tmpArray);
			TermCriteria retVal = new TermCriteria (tmpArray);
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  bool getCalculateVarImportance()
				//

				//javadoc: RTrees::getCalculateVarImportance()
				public  bool getCalculateVarImportance ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = ml_RTrees_getCalculateVarImportance_10(nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}


				//
				// C++:  int getActiveVarCount()
				//

				//javadoc: RTrees::getActiveVarCount()
				public  int getActiveVarCount ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = ml_RTrees_getActiveVarCount_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  void setActiveVarCount(int val)
				//

				//javadoc: RTrees::setActiveVarCount(val)
				public  void setActiveVarCount (int val)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_RTrees_setActiveVarCount_10(nativeObj, val);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setCalculateVarImportance(bool val)
				//

				//javadoc: RTrees::setCalculateVarImportance(val)
				public  void setCalculateVarImportance (bool val)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_RTrees_setCalculateVarImportance_10(nativeObj, val);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setTermCriteria(TermCriteria val)
				//

				//javadoc: RTrees::setTermCriteria(val)
				public  void setTermCriteria (TermCriteria val)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_RTrees_setTermCriteria_10(nativeObj, val.type, val.maxCount, val.epsilon);
        
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


				// C++:  Mat getVarImportance()
				[DllImport(LIBNAME)]
				private static extern IntPtr ml_RTrees_getVarImportance_10 (IntPtr nativeObj);

				// C++: static Ptr_RTrees create()
				[DllImport(LIBNAME)]
				private static extern IntPtr ml_RTrees_create_10 ();

				// C++:  TermCriteria getTermCriteria()
				[DllImport(LIBNAME)]
				private static extern void ml_RTrees_getTermCriteria_10 (IntPtr nativeObj, double[] vals);

				// C++:  bool getCalculateVarImportance()
				[DllImport(LIBNAME)]
				private static extern bool ml_RTrees_getCalculateVarImportance_10 (IntPtr nativeObj);

				// C++:  int getActiveVarCount()
				[DllImport(LIBNAME)]
				private static extern int ml_RTrees_getActiveVarCount_10 (IntPtr nativeObj);

				// C++:  void setActiveVarCount(int val)
				[DllImport(LIBNAME)]
				private static extern void ml_RTrees_setActiveVarCount_10 (IntPtr nativeObj, int val);

				// C++:  void setCalculateVarImportance(bool val)
				[DllImport(LIBNAME)]
				private static extern void ml_RTrees_setCalculateVarImportance_10 (IntPtr nativeObj, bool val);

				// C++:  void setTermCriteria(TermCriteria val)
				[DllImport(LIBNAME)]
				private static extern void ml_RTrees_setTermCriteria_10 (IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void ml_RTrees_delete (IntPtr nativeObj);

		}
}
