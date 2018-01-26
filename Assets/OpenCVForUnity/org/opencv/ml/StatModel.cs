
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class StatModel
//javadoc: StatModel
		public class StatModel : Algorithm
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ml_StatModel_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				protected StatModel (IntPtr addr) : base(addr)
				{
				}

				public const int						UPDATE_MODEL = 1;
				public const int						RAW_OUTPUT = 1;
				public const int						COMPRESSED_INPUT = 2;
				public const int						PREPROCESSED_INPUT = 4;



				//
				// C++:  bool empty()
				//

				//javadoc: StatModel::empty()
				public  bool empty ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = ml_StatModel_empty_10(nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}


				//
				// C++:  bool isClassifier()
				//

				//javadoc: StatModel::isClassifier()
				public  bool isClassifier ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = ml_StatModel_isClassifier_10(nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}


				//
				// C++:  bool isTrained()
				//

				//javadoc: StatModel::isTrained()
				public  bool isTrained ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = ml_StatModel_isTrained_10(nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}


				//
				// C++:  bool train(Mat samples, int layout, Mat responses)
				//

				//javadoc: StatModel::train(samples, layout, responses)
				public  bool train (Mat samples, int layout, Mat responses)
				{
						ThrowIfDisposed ();
						if (samples != null)
								samples.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = ml_StatModel_train_10(nativeObj, samples.nativeObj, layout, responses.nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}


				//
				// C++:  bool train(Ptr_TrainData trainData, int flags = 0)
				//

				// Unknown type 'Ptr_TrainData' (I), skipping the function


				//
				// C++:  float calcError(Ptr_TrainData data, bool test, Mat& resp)
				//

				// Unknown type 'Ptr_TrainData' (I), skipping the function


				//
				// C++:  float predict(Mat samples, Mat& results = Mat(), int flags = 0)
				//

				//javadoc: StatModel::predict(samples, results, flags)
				public virtual float predict (Mat samples, Mat results, int flags)
				{
						ThrowIfDisposed ();
						if (samples != null)
								samples.ThrowIfDisposed ();
						if (results != null)
								results.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        float retVal = ml_StatModel_predict_10(nativeObj, samples.nativeObj, results.nativeObj, flags);
        
        return retVal;
#else
						return -1;
#endif
				}

				//javadoc: StatModel::predict(samples)
				public virtual float predict (Mat samples)
				{
						ThrowIfDisposed ();
						if (samples != null)
								samples.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        float retVal = ml_StatModel_predict_11(nativeObj, samples.nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  int getVarCount()
				//

				//javadoc: StatModel::getVarCount()
				public  int getVarCount ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = ml_StatModel_getVarCount_10(nativeObj);
        
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


				// C++:  bool empty()
				[DllImport(LIBNAME)]
				private static extern bool ml_StatModel_empty_10 (IntPtr nativeObj);

				// C++:  bool isClassifier()
				[DllImport(LIBNAME)]
				private static extern bool ml_StatModel_isClassifier_10 (IntPtr nativeObj);

				// C++:  bool isTrained()
				[DllImport(LIBNAME)]
				private static extern bool ml_StatModel_isTrained_10 (IntPtr nativeObj);

				// C++:  bool train(Mat samples, int layout, Mat responses)
				[DllImport(LIBNAME)]
				private static extern bool ml_StatModel_train_10 (IntPtr nativeObj, IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj);

				// C++:  float predict(Mat samples, Mat& results = Mat(), int flags = 0)
				[DllImport(LIBNAME)]
				private static extern float ml_StatModel_predict_10 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj, int flags);

				[DllImport(LIBNAME)]
				private static extern float ml_StatModel_predict_11 (IntPtr nativeObj, IntPtr samples_nativeObj);

				// C++:  int getVarCount()
				[DllImport(LIBNAME)]
				private static extern int ml_StatModel_getVarCount_10 (IntPtr nativeObj);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void ml_StatModel_delete (IntPtr nativeObj);

		}
}
