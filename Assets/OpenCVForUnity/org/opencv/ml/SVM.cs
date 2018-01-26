
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class SVM
//javadoc: SVM
		public class SVM : StatModel
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ml_SVM_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				protected SVM (IntPtr addr) : base(addr)
				{
				}

				public const int						C_SVC = 100;
				public const int						NU_SVC = 101;
				public const int						ONE_CLASS = 102;
				public const int						EPS_SVR = 103;
				public const int						NU_SVR = 104;
				public const int						CUSTOM = -1;
				public const int						LINEAR = 0;
				public const int						POLY = 1;
				public const int						RBF = 2;
				public const int						SIGMOID = 3;
				public const int						CHI2 = 4;
				public const int						INTER = 5;
				public const int						C = 0;
				public const int						GAMMA = 1;
				public const int						P = 2;
				public const int						NU = 3;
				public const int						COEF = 4;
				public const int						DEGREE = 5;



				//
				// C++:  Mat getClassWeights()
				//

				//javadoc: SVM::getClassWeights()
				public  Mat getClassWeights ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Mat retVal = new Mat(ml_SVM_getClassWeights_10(nativeObj));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  Mat getSupportVectors()
				//

				//javadoc: SVM::getSupportVectors()
				public  Mat getSupportVectors ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Mat retVal = new Mat(ml_SVM_getSupportVectors_10(nativeObj));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  Mat getUncompressedSupportVectors()
				//

				//javadoc: SVM::getUncompressedSupportVectors()
				public  Mat getUncompressedSupportVectors ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Mat retVal = new Mat(ml_SVM_getUncompressedSupportVectors_10(nativeObj));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++: static Ptr_SVM create()
				//

				//javadoc: SVM::create()
				public static SVM create ()
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        SVM retVal = new SVM(ml_SVM_create_10());
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  TermCriteria getTermCriteria()
				//

				//javadoc: SVM::getTermCriteria()
				public  TermCriteria getTermCriteria ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double[] tmpArray = new double[3];
			ml_SVM_getTermCriteria_10 (nativeObj, tmpArray);
			TermCriteria retVal = new TermCriteria (tmpArray);
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  double getC()
				//

				//javadoc: SVM::getC()
				public  double getC ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double retVal = ml_SVM_getC_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  double getCoef0()
				//

				//javadoc: SVM::getCoef0()
				public  double getCoef0 ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double retVal = ml_SVM_getCoef0_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  double getDecisionFunction(int i, Mat& alpha, Mat& svidx)
				//

				//javadoc: SVM::getDecisionFunction(i, alpha, svidx)
				public  double getDecisionFunction (int i, Mat alpha, Mat svidx)
				{
						ThrowIfDisposed ();
						if (alpha != null)
								alpha.ThrowIfDisposed ();
						if (svidx != null)
								svidx.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double retVal = ml_SVM_getDecisionFunction_10(nativeObj, i, alpha.nativeObj, svidx.nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  double getDegree()
				//

				//javadoc: SVM::getDegree()
				public  double getDegree ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double retVal = ml_SVM_getDegree_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  double getGamma()
				//

				//javadoc: SVM::getGamma()
				public  double getGamma ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double retVal = ml_SVM_getGamma_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  double getNu()
				//

				//javadoc: SVM::getNu()
				public  double getNu ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double retVal = ml_SVM_getNu_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  double getP()
				//

				//javadoc: SVM::getP()
				public  double getP ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double retVal = ml_SVM_getP_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  int getKernelType()
				//

				//javadoc: SVM::getKernelType()
				public  int getKernelType ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = ml_SVM_getKernelType_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  int getType()
				//

				//javadoc: SVM::getType()
				public  int getType ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = ml_SVM_getType_10(nativeObj);
        
        return retVal;
#else
						return -1;
#endif
				}


				//
				// C++:  void setC(double val)
				//

				//javadoc: SVM::setC(val)
				public  void setC (double val)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_SVM_setC_10(nativeObj, val);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setClassWeights(Mat val)
				//

				//javadoc: SVM::setClassWeights(val)
				public  void setClassWeights (Mat val)
				{
						ThrowIfDisposed ();
						if (val != null)
								val.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_SVM_setClassWeights_10(nativeObj, val.nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setCoef0(double val)
				//

				//javadoc: SVM::setCoef0(val)
				public  void setCoef0 (double val)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_SVM_setCoef0_10(nativeObj, val);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setDegree(double val)
				//

				//javadoc: SVM::setDegree(val)
				public  void setDegree (double val)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_SVM_setDegree_10(nativeObj, val);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setGamma(double val)
				//

				//javadoc: SVM::setGamma(val)
				public  void setGamma (double val)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_SVM_setGamma_10(nativeObj, val);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setKernel(int kernelType)
				//

				//javadoc: SVM::setKernel(kernelType)
				public  void setKernel (int kernelType)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_SVM_setKernel_10(nativeObj, kernelType);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setNu(double val)
				//

				//javadoc: SVM::setNu(val)
				public  void setNu (double val)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_SVM_setNu_10(nativeObj, val);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setP(double val)
				//

				//javadoc: SVM::setP(val)
				public  void setP (double val)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_SVM_setP_10(nativeObj, val);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setTermCriteria(TermCriteria val)
				//

				//javadoc: SVM::setTermCriteria(val)
				public  void setTermCriteria (TermCriteria val)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_SVM_setTermCriteria_10(nativeObj, val.type, val.maxCount, val.epsilon);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setType(int val)
				//

				//javadoc: SVM::setType(val)
				public  void setType (int val)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ml_SVM_setType_10(nativeObj, val);
        
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


				// C++:  Mat getClassWeights()
				[DllImport(LIBNAME)]
				private static extern IntPtr ml_SVM_getClassWeights_10 (IntPtr nativeObj);

				// C++:  Mat getSupportVectors()
				[DllImport(LIBNAME)]
				private static extern IntPtr ml_SVM_getSupportVectors_10 (IntPtr nativeObj);

				// C++:  Mat getUncompressedSupportVectors()
				[DllImport(LIBNAME)]
				private static extern IntPtr ml_SVM_getUncompressedSupportVectors_10 (IntPtr nativeObj);

				// C++: static Ptr_SVM create()
				[DllImport(LIBNAME)]
				private static extern IntPtr ml_SVM_create_10 ();

				// C++:  TermCriteria getTermCriteria()
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_getTermCriteria_10 (IntPtr nativeObj, double[] vals);

				// C++:  double getC()
				[DllImport(LIBNAME)]
				private static extern double ml_SVM_getC_10 (IntPtr nativeObj);

				// C++:  double getCoef0()
				[DllImport(LIBNAME)]
				private static extern double ml_SVM_getCoef0_10 (IntPtr nativeObj);

				// C++:  double getDecisionFunction(int i, Mat& alpha, Mat& svidx)
				[DllImport(LIBNAME)]
				private static extern double ml_SVM_getDecisionFunction_10 (IntPtr nativeObj, int i, IntPtr alpha_nativeObj, IntPtr svidx_nativeObj);

				// C++:  double getDegree()
				[DllImport(LIBNAME)]
				private static extern double ml_SVM_getDegree_10 (IntPtr nativeObj);

				// C++:  double getGamma()
				[DllImport(LIBNAME)]
				private static extern double ml_SVM_getGamma_10 (IntPtr nativeObj);

				// C++:  double getNu()
				[DllImport(LIBNAME)]
				private static extern double ml_SVM_getNu_10 (IntPtr nativeObj);

				// C++:  double getP()
				[DllImport(LIBNAME)]
				private static extern double ml_SVM_getP_10 (IntPtr nativeObj);

				// C++:  int getKernelType()
				[DllImport(LIBNAME)]
				private static extern int ml_SVM_getKernelType_10 (IntPtr nativeObj);

				// C++:  int getType()
				[DllImport(LIBNAME)]
				private static extern int ml_SVM_getType_10 (IntPtr nativeObj);

				// C++:  void setC(double val)
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_setC_10 (IntPtr nativeObj, double val);

				// C++:  void setClassWeights(Mat val)
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_setClassWeights_10 (IntPtr nativeObj, IntPtr val_nativeObj);

				// C++:  void setCoef0(double val)
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_setCoef0_10 (IntPtr nativeObj, double val);

				// C++:  void setDegree(double val)
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_setDegree_10 (IntPtr nativeObj, double val);

				// C++:  void setGamma(double val)
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_setGamma_10 (IntPtr nativeObj, double val);

				// C++:  void setKernel(int kernelType)
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_setKernel_10 (IntPtr nativeObj, int kernelType);

				// C++:  void setNu(double val)
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_setNu_10 (IntPtr nativeObj, double val);

				// C++:  void setP(double val)
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_setP_10 (IntPtr nativeObj, double val);

				// C++:  void setTermCriteria(TermCriteria val)
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_setTermCriteria_10 (IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);

				// C++:  void setType(int val)
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_setType_10 (IntPtr nativeObj, int val);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void ml_SVM_delete (IntPtr nativeObj);

		}
}
