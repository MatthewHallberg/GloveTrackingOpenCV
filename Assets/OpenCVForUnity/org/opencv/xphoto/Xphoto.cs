
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class Xphoto
		{

				public const int						INPAINT_SHIFTMAP = 0;
				public const int						WHITE_BALANCE_SIMPLE = 0;
				public const int						WHITE_BALANCE_GRAYWORLD = 1;



				//
				// C++:  void autowbGrayworld(Mat src, Mat& dst, float thresh = 0.5f)
				//

				//javadoc: autowbGrayworld(src, dst, thresh)
				public static void autowbGrayworld (Mat src, Mat dst, float thresh)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xphoto_Xphoto_autowbGrayworld_10(src.nativeObj, dst.nativeObj, thresh);
        
        return;
#else
						return;
#endif
				}

				//javadoc: autowbGrayworld(src, dst)
				public static void autowbGrayworld (Mat src, Mat dst)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xphoto_Xphoto_autowbGrayworld_11(src.nativeObj, dst.nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void balanceWhite(Mat src, Mat dst, int algorithmType, float inputMin = 0.0f, float inputMax = 255.0f, float outputMin = 0.0f, float outputMax = 255.0f)
				//

				//javadoc: balanceWhite(src, dst, algorithmType, inputMin, inputMax, outputMin, outputMax)
				public static void balanceWhite (Mat src, Mat dst, int algorithmType, float inputMin, float inputMax, float outputMin, float outputMax)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xphoto_Xphoto_balanceWhite_10(src.nativeObj, dst.nativeObj, algorithmType, inputMin, inputMax, outputMin, outputMax);
        
        return;
#else
						return;
#endif
				}

				//javadoc: balanceWhite(src, dst, algorithmType)
				public static void balanceWhite (Mat src, Mat dst, int algorithmType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xphoto_Xphoto_balanceWhite_11(src.nativeObj, dst.nativeObj, algorithmType);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void dctDenoising(Mat src, Mat dst, double sigma, int psize = 16)
				//

				//javadoc: dctDenoising(src, dst, sigma, psize)
				public static void dctDenoising (Mat src, Mat dst, double sigma, int psize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xphoto_Xphoto_dctDenoising_10(src.nativeObj, dst.nativeObj, sigma, psize);
        
        return;
#else
						return;
#endif
				}

				//javadoc: dctDenoising(src, dst, sigma)
				public static void dctDenoising (Mat src, Mat dst, double sigma)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xphoto_Xphoto_dctDenoising_11(src.nativeObj, dst.nativeObj, sigma);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void inpaint(Mat src, Mat mask, Mat dst, int algorithmType)
				//

				//javadoc: inpaint(src, mask, dst, algorithmType)
				public static void inpaint (Mat src, Mat mask, Mat dst, int algorithmType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xphoto_Xphoto_inpaint_10(src.nativeObj, mask.nativeObj, dst.nativeObj, algorithmType);
        
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

				// C++:  void autowbGrayworld(Mat src, Mat& dst, float thresh = 0.5f)
				[DllImport(LIBNAME)]
				private static extern void xphoto_Xphoto_autowbGrayworld_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, float thresh);

				[DllImport(LIBNAME)]
				private static extern void xphoto_Xphoto_autowbGrayworld_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

				// C++:  void balanceWhite(Mat src, Mat dst, int algorithmType, float inputMin = 0.0f, float inputMax = 255.0f, float outputMin = 0.0f, float outputMax = 255.0f)
				[DllImport(LIBNAME)]
				private static extern void xphoto_Xphoto_balanceWhite_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int algorithmType, float inputMin, float inputMax, float outputMin, float outputMax);

				[DllImport(LIBNAME)]
				private static extern void xphoto_Xphoto_balanceWhite_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int algorithmType);

				// C++:  void dctDenoising(Mat src, Mat dst, double sigma, int psize = 16)
				[DllImport(LIBNAME)]
				private static extern void xphoto_Xphoto_dctDenoising_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma, int psize);

				[DllImport(LIBNAME)]
				private static extern void xphoto_Xphoto_dctDenoising_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma);

				// C++:  void inpaint(Mat src, Mat mask, Mat dst, int algorithmType)
				[DllImport(LIBNAME)]
				private static extern void xphoto_Xphoto_inpaint_10 (IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, int algorithmType);

		}
}
