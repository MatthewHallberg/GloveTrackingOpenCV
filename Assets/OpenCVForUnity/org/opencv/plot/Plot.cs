
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class Plot
		{

				//
				// C++:  Ptr_Plot2d createPlot2d(Mat data)
				//

				//javadoc: createPlot2d(data)
				public static Plot2d createPlot2d (Mat data)
				{
						if (data != null)
								data.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Plot2d retVal = new Plot2d(plot_Plot_createPlot2d_10(data.nativeObj));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  Ptr_Plot2d createPlot2d(Mat dataX, Mat dataY)
				//

				//javadoc: createPlot2d(dataX, dataY)
				public static Plot2d createPlot2d (Mat dataX, Mat dataY)
				{
						if (dataX != null)
								dataX.ThrowIfDisposed ();
						if (dataY != null)
								dataY.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Plot2d retVal = new Plot2d(plot_Plot_createPlot2d_11(dataX.nativeObj, dataY.nativeObj));
        
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

				// C++:  Ptr_Plot2d createPlot2d(Mat data)
				[DllImport(LIBNAME)]
				private static extern IntPtr plot_Plot_createPlot2d_10 (IntPtr data_nativeObj);

				// C++:  Ptr_Plot2d createPlot2d(Mat dataX, Mat dataY)
				[DllImport(LIBNAME)]
				private static extern IntPtr plot_Plot_createPlot2d_11 (IntPtr dataX_nativeObj, IntPtr dataY_nativeObj);

		}
}
