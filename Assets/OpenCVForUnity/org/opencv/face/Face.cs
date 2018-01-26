
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class Face
		{

				//
				// C++:  Ptr_BasicFaceRecognizer createEigenFaceRecognizer(int num_components = 0, double threshold = DBL_MAX)
				//

				//javadoc: createEigenFaceRecognizer(num_components, threshold)
				public static BasicFaceRecognizer createEigenFaceRecognizer (int num_components, double threshold)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BasicFaceRecognizer retVal = new BasicFaceRecognizer(face_Face_createEigenFaceRecognizer_10(num_components, threshold));
        
        return retVal;
#else
						return null;
#endif
				}

				//javadoc: createEigenFaceRecognizer()
				public static BasicFaceRecognizer createEigenFaceRecognizer ()
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BasicFaceRecognizer retVal = new BasicFaceRecognizer(face_Face_createEigenFaceRecognizer_11());
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  Ptr_BasicFaceRecognizer createFisherFaceRecognizer(int num_components = 0, double threshold = DBL_MAX)
				//

				//javadoc: createFisherFaceRecognizer(num_components, threshold)
				public static BasicFaceRecognizer createFisherFaceRecognizer (int num_components, double threshold)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BasicFaceRecognizer retVal = new BasicFaceRecognizer(face_Face_createFisherFaceRecognizer_10(num_components, threshold));
        
        return retVal;
#else
						return null;
#endif
				}

				//javadoc: createFisherFaceRecognizer()
				public static BasicFaceRecognizer createFisherFaceRecognizer ()
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BasicFaceRecognizer retVal = new BasicFaceRecognizer(face_Face_createFisherFaceRecognizer_11());
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  Ptr_LBPHFaceRecognizer createLBPHFaceRecognizer(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
				//

				//javadoc: createLBPHFaceRecognizer(radius, neighbors, grid_x, grid_y, threshold)
				public static LBPHFaceRecognizer createLBPHFaceRecognizer (int radius, int neighbors, int grid_x, int grid_y, double threshold)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        LBPHFaceRecognizer retVal = new LBPHFaceRecognizer(face_Face_createLBPHFaceRecognizer_10(radius, neighbors, grid_x, grid_y, threshold));
        
        return retVal;
#else
						return null;
#endif
				}

				//javadoc: createLBPHFaceRecognizer()
				public static LBPHFaceRecognizer createLBPHFaceRecognizer ()
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        LBPHFaceRecognizer retVal = new LBPHFaceRecognizer(face_Face_createLBPHFaceRecognizer_11());
        
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


				// C++:  Ptr_BasicFaceRecognizer createEigenFaceRecognizer(int num_components = 0, double threshold = DBL_MAX)
				[DllImport(LIBNAME)]
				private static extern IntPtr face_Face_createEigenFaceRecognizer_10 (int num_components, double threshold);

				[DllImport(LIBNAME)]
				private static extern IntPtr face_Face_createEigenFaceRecognizer_11 ();

				// C++:  Ptr_BasicFaceRecognizer createFisherFaceRecognizer(int num_components = 0, double threshold = DBL_MAX)
				[DllImport(LIBNAME)]
				private static extern IntPtr face_Face_createFisherFaceRecognizer_10 (int num_components, double threshold);

				[DllImport(LIBNAME)]
				private static extern IntPtr face_Face_createFisherFaceRecognizer_11 ();

				// C++:  Ptr_LBPHFaceRecognizer createLBPHFaceRecognizer(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
				[DllImport(LIBNAME)]
				private static extern IntPtr face_Face_createLBPHFaceRecognizer_10 (int radius, int neighbors, int grid_x, int grid_y, double threshold);

				[DllImport(LIBNAME)]
				private static extern IntPtr face_Face_createLBPHFaceRecognizer_11 ();

		}
}
