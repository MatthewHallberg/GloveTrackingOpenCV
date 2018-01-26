
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class Imgcodecs
		{

				public const int            CV_LOAD_IMAGE_UNCHANGED = -1;
				public const int            CV_LOAD_IMAGE_GRAYSCALE = 0;
				public const int            CV_LOAD_IMAGE_COLOR = 1;
				public const int            CV_LOAD_IMAGE_ANYDEPTH = 2;
				public const int            CV_LOAD_IMAGE_ANYCOLOR = 4;
				public const int            CV_IMWRITE_JPEG_QUALITY = 1;
				public const int            CV_IMWRITE_JPEG_PROGRESSIVE = 2;
				public const int            CV_IMWRITE_JPEG_OPTIMIZE = 3;
				public const int            CV_IMWRITE_JPEG_RST_INTERVAL = 4;
				public const int            CV_IMWRITE_JPEG_LUMA_QUALITY = 5;
				public const int            CV_IMWRITE_JPEG_CHROMA_QUALITY = 6;
				public const int            CV_IMWRITE_PNG_COMPRESSION = 16;
				public const int            CV_IMWRITE_PNG_STRATEGY = 17;
				public const int            CV_IMWRITE_PNG_BILEVEL = 18;
				public const int            CV_IMWRITE_PNG_STRATEGY_DEFAULT = 0;
				public const int            CV_IMWRITE_PNG_STRATEGY_FILTERED = 1;
				public const int            CV_IMWRITE_PNG_STRATEGY_HUFFMAN_ONLY = 2;
				public const int            CV_IMWRITE_PNG_STRATEGY_RLE = 3;
				public const int            CV_IMWRITE_PNG_STRATEGY_FIXED = 4;
				public const int            CV_IMWRITE_PXM_BINARY = 32;
				public const int            CV_IMWRITE_WEBP_QUALITY = 64;
				public const int            CV_CVTIMG_FLIP = 1;
				public const int            CV_CVTIMG_SWAP_RB = 2;
				public const int            IMREAD_UNCHANGED = -1;
				public const int            IMREAD_GRAYSCALE = 0;
				public const int            IMREAD_COLOR = 1;
				public const int            IMREAD_ANYDEPTH = 2;
				public const int            IMREAD_ANYCOLOR = 4;
				public const int            IMREAD_LOAD_GDAL = 8;
				public const int            IMREAD_REDUCED_GRAYSCALE_2 = 16;
				public const int            IMREAD_REDUCED_COLOR_2 = 17;
				public const int            IMREAD_REDUCED_GRAYSCALE_4 = 32;
				public const int            IMREAD_REDUCED_COLOR_4 = 33;
				public const int            IMREAD_REDUCED_GRAYSCALE_8 = 64;
				public const int            IMREAD_REDUCED_COLOR_8 = 65;
				public const int            IMWRITE_JPEG_QUALITY = 1;
				public const int            IMWRITE_JPEG_PROGRESSIVE = 2;
				public const int            IMWRITE_JPEG_OPTIMIZE = 3;
				public const int            IMWRITE_JPEG_RST_INTERVAL = 4;
				public const int            IMWRITE_JPEG_LUMA_QUALITY = 5;
				public const int            IMWRITE_JPEG_CHROMA_QUALITY = 6;
				public const int            IMWRITE_PNG_COMPRESSION = 16;
				public const int            IMWRITE_PNG_STRATEGY = 17;
				public const int            IMWRITE_PNG_BILEVEL = 18;
				public const int            IMWRITE_PXM_BINARY = 32;
				public const int            IMWRITE_WEBP_QUALITY = 64;
				public const int            IMWRITE_PNG_STRATEGY_DEFAULT = 0;
				public const int            IMWRITE_PNG_STRATEGY_FILTERED = 1;
				public const int            IMWRITE_PNG_STRATEGY_HUFFMAN_ONLY = 2;
				public const int            IMWRITE_PNG_STRATEGY_RLE = 3;
				public const int            IMWRITE_PNG_STRATEGY_FIXED = 4;



				//
				// C++:  Mat imdecode(Mat buf, int flags)
				//

				//javadoc: imdecode(buf, flags)
				public static Mat imdecode (Mat buf, int flags)
				{
						if (buf != null)
								buf.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Mat retVal = new Mat(imgcodecs_Imgcodecs_imdecode_10(buf.nativeObj, flags));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  Mat imread(string filename, int flags = IMREAD_COLOR)
				//

				//javadoc: imread(filename, flags)
				public static Mat imread (string filename, int flags)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Mat retVal = new Mat(imgcodecs_Imgcodecs_imread_10(filename, flags));
        
        return retVal;
#else
						return null;
#endif
				}

				//javadoc: imread(filename)
				public static Mat imread (string filename)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Mat retVal = new Mat(imgcodecs_Imgcodecs_imread_11(filename));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  bool imencode(string ext, Mat img, vector_uchar& buf, vector_int params = std::vector<int>())
				//

				//javadoc: imencode(ext, img, buf, params)
				public static bool imencode (string ext, Mat img, MatOfByte buf, MatOfInt _params)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (buf != null)
								buf.ThrowIfDisposed ();
						if (_params != null)
								_params.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat buf_mat = buf;
        Mat params_mat = _params;
        bool retVal = imgcodecs_Imgcodecs_imencode_10(ext, img.nativeObj, buf_mat.nativeObj, params_mat.nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}

				//javadoc: imencode(ext, img, buf)
				public static bool imencode (string ext, Mat img, MatOfByte buf)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (buf != null)
								buf.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat buf_mat = buf;
        bool retVal = imgcodecs_Imgcodecs_imencode_11(ext, img.nativeObj, buf_mat.nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}


				//
				// C++:  bool imreadmulti(string filename, vector_Mat mats, int flags = IMREAD_ANYCOLOR)
				//

				//javadoc: imreadmulti(filename, mats, flags)
				public static bool imreadmulti (string filename, List<Mat> mats, int flags)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat mats_mat = Converters.vector_Mat_to_Mat(mats);
        bool retVal = imgcodecs_Imgcodecs_imreadmulti_10(filename, mats_mat.nativeObj, flags);
        
        return retVal;
#else
						return false;
#endif
				}

				//javadoc: imreadmulti(filename, mats)
				public static bool imreadmulti (string filename, List<Mat> mats)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat mats_mat = Converters.vector_Mat_to_Mat(mats);
        bool retVal = imgcodecs_Imgcodecs_imreadmulti_11(filename, mats_mat.nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}


				//
				// C++:  bool imwrite(string filename, Mat img, vector_int params = std::vector<int>())
				//

				//javadoc: imwrite(filename, img, params)
				public static bool imwrite (string filename, Mat img, MatOfInt _params)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (_params != null)
								_params.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat params_mat = _params;
        bool retVal = imgcodecs_Imgcodecs_imwrite_10(filename, img.nativeObj, params_mat.nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}

				//javadoc: imwrite(filename, img)
				public static bool imwrite (string filename, Mat img)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = imgcodecs_Imgcodecs_imwrite_11(filename, img.nativeObj);
        
        return retVal;
#else
						return false;
#endif
				}


		#if UNITY_IOS && !UNITY_EDITOR
		const string LIBNAME = "__Internal";
		#else
				const string LIBNAME = "opencvforunity";
		#endif

				// C++:  Mat imdecode(Mat buf, int flags)
				[DllImport(LIBNAME)]
				private static extern IntPtr imgcodecs_Imgcodecs_imdecode_10 (IntPtr buf_nativeObj, int flags);

				// C++:  Mat imread(string filename, int flags = IMREAD_COLOR)
				[DllImport(LIBNAME)]
				private static extern IntPtr imgcodecs_Imgcodecs_imread_10 (string filename, int flags);

				[DllImport(LIBNAME)]
				private static extern IntPtr imgcodecs_Imgcodecs_imread_11 (string filename);

				// C++:  bool imencode(string ext, Mat img, vector_uchar& buf, vector_int params = std::vector<int>())
				[DllImport(LIBNAME)]
				private static extern bool imgcodecs_Imgcodecs_imencode_10 (string ext, IntPtr img_nativeObj, IntPtr buf_mat_nativeObj, IntPtr params_mat_nativeObj);

				[DllImport(LIBNAME)]
				private static extern bool imgcodecs_Imgcodecs_imencode_11 (string ext, IntPtr img_nativeObj, IntPtr buf_mat_nativeObj);

				// C++:  bool imreadmulti(string filename, vector_Mat mats, int flags = IMREAD_ANYCOLOR)
				[DllImport(LIBNAME)]
				private static extern bool imgcodecs_Imgcodecs_imreadmulti_10 (string filename, IntPtr mats_mat_nativeObj, int flags);

				[DllImport(LIBNAME)]
				private static extern bool imgcodecs_Imgcodecs_imreadmulti_11 (string filename, IntPtr mats_mat_nativeObj);

				// C++:  bool imwrite(string filename, Mat img, vector_int params = std::vector<int>())
				[DllImport(LIBNAME)]
				private static extern bool imgcodecs_Imgcodecs_imwrite_10 (string filename, IntPtr img_nativeObj, IntPtr params_mat_nativeObj);

				[DllImport(LIBNAME)]
				private static extern bool imgcodecs_Imgcodecs_imwrite_11 (string filename, IntPtr img_nativeObj);

		}
}
