
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class javaDescriptorMatcher
//javadoc: javaDescriptorMatcher
		public class DescriptorMatcher : DisposableOpenCVObject
		{

				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
features2d_DescriptorMatcher_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				protected DescriptorMatcher (IntPtr addr) : base(addr)
				{
				}

				public const int						FLANNBASED = 1;
				public const int						BRUTEFORCE = 2;
				public const int						BRUTEFORCE_L1 = 3;
				public const int						BRUTEFORCE_HAMMING = 4;
				public const int						BRUTEFORCE_HAMMINGLUT = 5;
				public const int						BRUTEFORCE_SL2 = 6;



				//
				// C++:  bool empty()
				//

				//javadoc: javaDescriptorMatcher::empty()
				public  bool empty ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = features2d_DescriptorMatcher_empty_10(nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}


				//
				// C++:  bool isMaskSupported()
				//

				//javadoc: javaDescriptorMatcher::isMaskSupported()
				public  bool isMaskSupported ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = features2d_DescriptorMatcher_isMaskSupported_10(nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}


				//
				// C++: static javaDescriptorMatcher* create(int matcherType)
				//

				//javadoc: javaDescriptorMatcher::create(matcherType)
				public static DescriptorMatcher create (int matcherType)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        DescriptorMatcher retVal = new DescriptorMatcher(features2d_DescriptorMatcher_create_10(matcherType));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  javaDescriptorMatcher* jclone(bool emptyTrainData = false)
				//

				//javadoc: javaDescriptorMatcher::jclone(emptyTrainData)
				public  DescriptorMatcher clone (bool emptyTrainData)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        DescriptorMatcher retVal = new DescriptorMatcher(features2d_DescriptorMatcher_clone_10(nativeObj, emptyTrainData));
        
        return retVal;
#else
						return null;
#endif
				}

				//javadoc: javaDescriptorMatcher::jclone()
				public  DescriptorMatcher clone ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        DescriptorMatcher retVal = new DescriptorMatcher(features2d_DescriptorMatcher_clone_11(nativeObj));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  vector_Mat getTrainDescriptors()
				//

				//javadoc: javaDescriptorMatcher::getTrainDescriptors()
				public  List<Mat> getTrainDescriptors ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        List<Mat> retVal = new List<Mat>();
        Mat retValMat = new Mat(features2d_DescriptorMatcher_getTrainDescriptors_10(nativeObj));
        Converters.Mat_to_vector_Mat(retValMat, retVal);
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  void add(vector_Mat descriptors)
				//

				//javadoc: javaDescriptorMatcher::add(descriptors)
				public  void add (List<Mat> descriptors)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat descriptors_mat = Converters.vector_Mat_to_Mat(descriptors);
        features2d_DescriptorMatcher_add_10(nativeObj, descriptors_mat.nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void clear()
				//

				//javadoc: javaDescriptorMatcher::clear()
				public  void clear ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        features2d_DescriptorMatcher_clear_10(nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void knnMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
				//

				//javadoc: javaDescriptorMatcher::knnMatch(queryDescriptors, trainDescriptors, matches, k, mask, compactResult)
				public  void knnMatch (Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k, Mat mask, bool compactResult)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_knnMatch_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k, mask.nativeObj, compactResult);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
						return;
#endif
				}

				//javadoc: javaDescriptorMatcher::knnMatch(queryDescriptors, trainDescriptors, matches, k)
				public  void knnMatch (Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_knnMatch_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
						return;
#endif
				}


				//
				// C++:  void knnMatch(Mat queryDescriptors, vector_vector_DMatch& matches, int k, vector_Mat masks = std::vector<Mat>(), bool compactResult = false)
				//

				//javadoc: javaDescriptorMatcher::knnMatch(queryDescriptors, matches, k, masks, compactResult)
				public  void knnMatch (Mat queryDescriptors, List<MatOfDMatch> matches, int k, List<Mat> masks, bool compactResult)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = new Mat();
        Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
        features2d_DescriptorMatcher_knnMatch_12(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k, masks_mat.nativeObj, compactResult);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
						return;
#endif
				}

				//javadoc: javaDescriptorMatcher::knnMatch(queryDescriptors, matches, k)
				public  void knnMatch (Mat queryDescriptors, List<MatOfDMatch> matches, int k)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_knnMatch_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
						return;
#endif
				}


				//
				// C++:  void match(Mat queryDescriptors, Mat trainDescriptors, vector_DMatch& matches, Mat mask = Mat())
				//

				//javadoc: javaDescriptorMatcher::match(queryDescriptors, trainDescriptors, matches, mask)
				public  void match (Mat queryDescriptors, Mat trainDescriptors, MatOfDMatch matches, Mat mask)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = matches;
        features2d_DescriptorMatcher_match_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, mask.nativeObj);
        
        return;
#else
						return;
#endif
				}

				//javadoc: javaDescriptorMatcher::match(queryDescriptors, trainDescriptors, matches)
				public  void match (Mat queryDescriptors, Mat trainDescriptors, MatOfDMatch matches)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = matches;
        features2d_DescriptorMatcher_match_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void match(Mat queryDescriptors, vector_DMatch& matches, vector_Mat masks = std::vector<Mat>())
				//

				//javadoc: javaDescriptorMatcher::match(queryDescriptors, matches, masks)
				public  void match (Mat queryDescriptors, MatOfDMatch matches, List<Mat> masks)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = matches;
        Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
        features2d_DescriptorMatcher_match_12(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, masks_mat.nativeObj);
        
        return;
#else
						return;
#endif
				}

				//javadoc: javaDescriptorMatcher::match(queryDescriptors, matches)
				public  void match (Mat queryDescriptors, MatOfDMatch matches)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = matches;
        features2d_DescriptorMatcher_match_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void radiusMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
				//

				//javadoc: javaDescriptorMatcher::radiusMatch(queryDescriptors, trainDescriptors, matches, maxDistance, mask, compactResult)
				public  void radiusMatch (Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance, Mat mask, bool compactResult)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_radiusMatch_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, mask.nativeObj, compactResult);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
						return;
#endif
				}

				//javadoc: javaDescriptorMatcher::radiusMatch(queryDescriptors, trainDescriptors, matches, maxDistance)
				public  void radiusMatch (Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_radiusMatch_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
						return;
#endif
				}


				//
				// C++:  void radiusMatch(Mat queryDescriptors, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = std::vector<Mat>(), bool compactResult = false)
				//

				//javadoc: javaDescriptorMatcher::radiusMatch(queryDescriptors, matches, maxDistance, masks, compactResult)
				public  void radiusMatch (Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance, List<Mat> masks, bool compactResult)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = new Mat();
        Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
        features2d_DescriptorMatcher_radiusMatch_12(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, masks_mat.nativeObj, compactResult);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
						return;
#endif
				}

				//javadoc: javaDescriptorMatcher::radiusMatch(queryDescriptors, matches, maxDistance)
				public  void radiusMatch (Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance)
				{
						ThrowIfDisposed ();
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat matches_mat = new Mat();
        features2d_DescriptorMatcher_radiusMatch_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance);
        Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        matches_mat.release();
        return;
#else
						return;
#endif
				}


				//
				// C++:  void read(string fileName)
				//

				//javadoc: javaDescriptorMatcher::read(fileName)
				public  void read (string fileName)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        features2d_DescriptorMatcher_read_10(nativeObj, fileName);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void train()
				//

				//javadoc: javaDescriptorMatcher::train()
				public  void train ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        features2d_DescriptorMatcher_train_10(nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void write(string fileName)
				//

				//javadoc: javaDescriptorMatcher::write(fileName)
				public  void write (string fileName)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        features2d_DescriptorMatcher_write_10(nativeObj, fileName);
        
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


				// C++:  bool empty()
				[DllImport(LIBNAME)]
				private static extern bool features2d_DescriptorMatcher_empty_10 (IntPtr nativeObj);

				// C++:  bool isMaskSupported()
				[DllImport(LIBNAME)]
				private static extern bool features2d_DescriptorMatcher_isMaskSupported_10 (IntPtr nativeObj);

				// C++: static javaDescriptorMatcher* create(int matcherType)
				[DllImport(LIBNAME)]
				private static extern IntPtr features2d_DescriptorMatcher_create_10 (int matcherType);

				// C++:  javaDescriptorMatcher* jclone(bool emptyTrainData = false)
				[DllImport(LIBNAME)]
				private static extern IntPtr features2d_DescriptorMatcher_clone_10 (IntPtr nativeObj, bool emptyTrainData);

				[DllImport(LIBNAME)]
				private static extern IntPtr features2d_DescriptorMatcher_clone_11 (IntPtr nativeObj);

				// C++:  vector_Mat getTrainDescriptors()
				[DllImport(LIBNAME)]
				private static extern IntPtr features2d_DescriptorMatcher_getTrainDescriptors_10 (IntPtr nativeObj);

				// C++:  void add(vector_Mat descriptors)
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_add_10 (IntPtr nativeObj, IntPtr descriptors_mat_nativeObj);

				// C++:  void clear()
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_clear_10 (IntPtr nativeObj);

				// C++:  void knnMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_knnMatch_10 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr mask_nativeObj, bool compactResult);

				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_knnMatch_11 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);

				// C++:  void knnMatch(Mat queryDescriptors, vector_vector_DMatch& matches, int k, vector_Mat masks = std::vector<Mat>(), bool compactResult = false)
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_knnMatch_12 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr masks_mat_nativeObj, bool compactResult);

				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_knnMatch_13 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);

				// C++:  void match(Mat queryDescriptors, Mat trainDescriptors, vector_DMatch& matches, Mat mask = Mat())
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_match_10 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr mask_nativeObj);

				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_match_11 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj);

				// C++:  void match(Mat queryDescriptors, vector_DMatch& matches, vector_Mat masks = std::vector<Mat>())
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_match_12 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr masks_mat_nativeObj);

				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_match_13 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj);

				// C++:  void radiusMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_radiusMatch_10 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr mask_nativeObj, bool compactResult);

				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_radiusMatch_11 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);

				// C++:  void radiusMatch(Mat queryDescriptors, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = std::vector<Mat>(), bool compactResult = false)
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_radiusMatch_12 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr masks_mat_nativeObj, bool compactResult);

				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_radiusMatch_13 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);

				// C++:  void read(string fileName)
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_read_10 (IntPtr nativeObj, string fileName);

				// C++:  void train()
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_train_10 (IntPtr nativeObj);

				// C++:  void write(string fileName)
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_write_10 (IntPtr nativeObj, string fileName);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void features2d_DescriptorMatcher_delete (IntPtr nativeObj);

		}
}
