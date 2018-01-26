
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class TransientAreasSegmentationModule
//javadoc: TransientAreasSegmentationModule
		public class TransientAreasSegmentationModule : Algorithm
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
bioinspired_TransientAreasSegmentationModule_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				public TransientAreasSegmentationModule (IntPtr addr) : base(addr)
				{
				}


				//
				// C++:  Size getSize()
				//

				//javadoc: TransientAreasSegmentationModule::getSize()
				public  Size getSize ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double[] tmpArray = new double[2];
						bioinspired_TransientAreasSegmentationModule_getSize_10 (nativeObj, tmpArray);
						Size retVal = new Size (tmpArray);
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  string printSetup()
				//

				//javadoc: TransientAreasSegmentationModule::printSetup()
				public  string printSetup ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
			string retVal = Marshal.PtrToStringAnsi (bioinspired_TransientAreasSegmentationModule_printSetup_10(nativeObj));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  void clearAllBuffers()
				//

				//javadoc: TransientAreasSegmentationModule::clearAllBuffers()
				public  void clearAllBuffers ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bioinspired_TransientAreasSegmentationModule_clearAllBuffers_10(nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void getSegmentationPicture(Mat& transientAreas)
				//

				//javadoc: TransientAreasSegmentationModule::getSegmentationPicture(transientAreas)
				public  void getSegmentationPicture (Mat transientAreas)
				{
						ThrowIfDisposed ();
						if (transientAreas != null)
								transientAreas.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bioinspired_TransientAreasSegmentationModule_getSegmentationPicture_10(nativeObj, transientAreas.nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void run(Mat inputToSegment, int channelIndex = 0)
				//

				//javadoc: TransientAreasSegmentationModule::run(inputToSegment, channelIndex)
				public  void run (Mat inputToSegment, int channelIndex)
				{
						ThrowIfDisposed ();
						if (inputToSegment != null)
								inputToSegment.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bioinspired_TransientAreasSegmentationModule_run_10(nativeObj, inputToSegment.nativeObj, channelIndex);
        
        return;
#else
						return;
#endif
				}

				//javadoc: TransientAreasSegmentationModule::run(inputToSegment)
				public  void run (Mat inputToSegment)
				{
						ThrowIfDisposed ();
						if (inputToSegment != null)
								inputToSegment.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bioinspired_TransientAreasSegmentationModule_run_11(nativeObj, inputToSegment.nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setup(string segmentationParameterFile = "", bool applyDefaultSetupOnFailure = true)
				//

				//javadoc: TransientAreasSegmentationModule::setup(segmentationParameterFile, applyDefaultSetupOnFailure)
				public  void setup (string segmentationParameterFile, bool applyDefaultSetupOnFailure)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bioinspired_TransientAreasSegmentationModule_setup_10(nativeObj, segmentationParameterFile, applyDefaultSetupOnFailure);
        
        return;
#else
						return;
#endif
				}

				//javadoc: TransientAreasSegmentationModule::setup()
				public  void setup ()
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bioinspired_TransientAreasSegmentationModule_setup_11(nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void write(string fs)
				//

				//javadoc: TransientAreasSegmentationModule::write(fs)
				public  void write (string fs)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bioinspired_TransientAreasSegmentationModule_write_10(nativeObj, fs);
        
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


				// C++:  Size getSize()
				[DllImport(LIBNAME)]
				private static extern void bioinspired_TransientAreasSegmentationModule_getSize_10 (IntPtr nativeObj, double[] vals);

				// C++:  string printSetup()
				[DllImport(LIBNAME)]
				private static extern IntPtr bioinspired_TransientAreasSegmentationModule_printSetup_10 (IntPtr nativeObj);

				// C++:  void clearAllBuffers()
				[DllImport(LIBNAME)]
				private static extern void bioinspired_TransientAreasSegmentationModule_clearAllBuffers_10 (IntPtr nativeObj);

				// C++:  void getSegmentationPicture(Mat& transientAreas)
				[DllImport(LIBNAME)]
				private static extern void bioinspired_TransientAreasSegmentationModule_getSegmentationPicture_10 (IntPtr nativeObj, IntPtr transientAreas_nativeObj);

				// C++:  void run(Mat inputToSegment, int channelIndex = 0)
				[DllImport(LIBNAME)]
				private static extern void bioinspired_TransientAreasSegmentationModule_run_10 (IntPtr nativeObj, IntPtr inputToSegment_nativeObj, int channelIndex);

				[DllImport(LIBNAME)]
				private static extern void bioinspired_TransientAreasSegmentationModule_run_11 (IntPtr nativeObj, IntPtr inputToSegment_nativeObj);

				// C++:  void setup(string segmentationParameterFile = "", bool applyDefaultSetupOnFailure = true)
				[DllImport(LIBNAME)]
				private static extern void bioinspired_TransientAreasSegmentationModule_setup_10 (IntPtr nativeObj, string segmentationParameterFile, bool applyDefaultSetupOnFailure);

				[DllImport(LIBNAME)]
				private static extern void bioinspired_TransientAreasSegmentationModule_setup_11 (IntPtr nativeObj);

				// C++:  void write(string fs)
				[DllImport(LIBNAME)]
				private static extern void bioinspired_TransientAreasSegmentationModule_write_10 (IntPtr nativeObj, string fs);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void bioinspired_TransientAreasSegmentationModule_delete (IntPtr nativeObj);

		}
}
