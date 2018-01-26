
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class RetinaFastToneMapping
//javadoc: RetinaFastToneMapping
		public class RetinaFastToneMapping : Algorithm
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
bioinspired_RetinaFastToneMapping_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				public RetinaFastToneMapping (IntPtr addr) : base(addr)
				{
				}


				//
				// C++:  void applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
				//

				//javadoc: RetinaFastToneMapping::applyFastToneMapping(inputImage, outputToneMappedImage)
				public  void applyFastToneMapping (Mat inputImage, Mat outputToneMappedImage)
				{
						ThrowIfDisposed ();
						if (inputImage != null)
								inputImage.ThrowIfDisposed ();
						if (outputToneMappedImage != null)
								outputToneMappedImage.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bioinspired_RetinaFastToneMapping_applyFastToneMapping_10(nativeObj, inputImage.nativeObj, outputToneMappedImage.nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setup(float photoreceptorsNeighborhoodRadius = 3.f, float ganglioncellsNeighborhoodRadius = 1.f, float meanLuminanceModulatorK = 1.f)
				//

				//javadoc: RetinaFastToneMapping::setup(photoreceptorsNeighborhoodRadius, ganglioncellsNeighborhoodRadius, meanLuminanceModulatorK)
				public  void setup (float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius, float meanLuminanceModulatorK)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bioinspired_RetinaFastToneMapping_setup_10(nativeObj, photoreceptorsNeighborhoodRadius, ganglioncellsNeighborhoodRadius, meanLuminanceModulatorK);
        
        return;
#else
						return;
#endif
				}

				//javadoc: RetinaFastToneMapping::setup()
				public  void setup ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bioinspired_RetinaFastToneMapping_setup_11(nativeObj);
        
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


				// C++:  void applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
				[DllImport(LIBNAME)]
				private static extern void bioinspired_RetinaFastToneMapping_applyFastToneMapping_10 (IntPtr nativeObj, IntPtr inputImage_nativeObj, IntPtr outputToneMappedImage_nativeObj);

				// C++:  void setup(float photoreceptorsNeighborhoodRadius = 3.f, float ganglioncellsNeighborhoodRadius = 1.f, float meanLuminanceModulatorK = 1.f)
				[DllImport(LIBNAME)]
				private static extern void bioinspired_RetinaFastToneMapping_setup_10 (IntPtr nativeObj, float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius, float meanLuminanceModulatorK);

				[DllImport(LIBNAME)]
				private static extern void bioinspired_RetinaFastToneMapping_setup_11 (IntPtr nativeObj);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void bioinspired_RetinaFastToneMapping_delete (IntPtr nativeObj);

		}
}
