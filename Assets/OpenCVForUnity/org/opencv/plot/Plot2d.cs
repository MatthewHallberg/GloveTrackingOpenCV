
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class Plot2d
//javadoc: Plot2d
		public class Plot2d : Algorithm
		{
				protected override void Dispose (bool disposing)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
plot_Plot2d_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
						return;
#endif
				}

				public Plot2d (IntPtr addr) : base(addr)
				{
				}


				//
				// C++:  void render(Mat _plotResult)
				//

				//javadoc: Plot2d::render(_plotResult)
				public  void render (Mat _plotResult)
				{
						ThrowIfDisposed ();
						if (_plotResult != null)
								_plotResult.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_render_10(nativeObj, _plotResult.nativeObj);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setMaxX(double _plotMaxX)
				//

				//javadoc: Plot2d::setMaxX(_plotMaxX)
				public  void setMaxX (double _plotMaxX)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_setMaxX_10(nativeObj, _plotMaxX);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setMaxY(double _plotMaxY)
				//

				//javadoc: Plot2d::setMaxY(_plotMaxY)
				public  void setMaxY (double _plotMaxY)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_setMaxY_10(nativeObj, _plotMaxY);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setMinX(double _plotMinX)
				//

				//javadoc: Plot2d::setMinX(_plotMinX)
				public  void setMinX (double _plotMinX)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_setMinX_10(nativeObj, _plotMinX);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setMinY(double _plotMinY)
				//

				//javadoc: Plot2d::setMinY(_plotMinY)
				public  void setMinY (double _plotMinY)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_setMinY_10(nativeObj, _plotMinY);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setPlotAxisColor(Scalar _plotAxisColor)
				//

				//javadoc: Plot2d::setPlotAxisColor(_plotAxisColor)
				public  void setPlotAxisColor (Scalar _plotAxisColor)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_setPlotAxisColor_10(nativeObj, _plotAxisColor.val[0], _plotAxisColor.val[1], _plotAxisColor.val[2], _plotAxisColor.val[3]);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setPlotBackgroundColor(Scalar _plotBackgroundColor)
				//

				//javadoc: Plot2d::setPlotBackgroundColor(_plotBackgroundColor)
				public  void setPlotBackgroundColor (Scalar _plotBackgroundColor)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_setPlotBackgroundColor_10(nativeObj, _plotBackgroundColor.val[0], _plotBackgroundColor.val[1], _plotBackgroundColor.val[2], _plotBackgroundColor.val[3]);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setPlotGridColor(Scalar _plotGridColor)
				//

				//javadoc: Plot2d::setPlotGridColor(_plotGridColor)
				public  void setPlotGridColor (Scalar _plotGridColor)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_setPlotGridColor_10(nativeObj, _plotGridColor.val[0], _plotGridColor.val[1], _plotGridColor.val[2], _plotGridColor.val[3]);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setPlotLineColor(Scalar _plotLineColor)
				//

				//javadoc: Plot2d::setPlotLineColor(_plotLineColor)
				public  void setPlotLineColor (Scalar _plotLineColor)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_setPlotLineColor_10(nativeObj, _plotLineColor.val[0], _plotLineColor.val[1], _plotLineColor.val[2], _plotLineColor.val[3]);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setPlotLineWidth(int _plotLineWidth)
				//

				//javadoc: Plot2d::setPlotLineWidth(_plotLineWidth)
				public  void setPlotLineWidth (int _plotLineWidth)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_setPlotLineWidth_10(nativeObj, _plotLineWidth);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setPlotSize(int _plotSizeWidth, int _plotSizeHeight)
				//

				//javadoc: Plot2d::setPlotSize(_plotSizeWidth, _plotSizeHeight)
				public  void setPlotSize (int _plotSizeWidth, int _plotSizeHeight)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_setPlotSize_10(nativeObj, _plotSizeWidth, _plotSizeHeight);
        
        return;
#else
						return;
#endif
				}


				//
				// C++:  void setPlotTextColor(Scalar _plotTextColor)
				//

				//javadoc: Plot2d::setPlotTextColor(_plotTextColor)
				public  void setPlotTextColor (Scalar _plotTextColor)
				{
						ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        plot_Plot2d_setPlotTextColor_10(nativeObj, _plotTextColor.val[0], _plotTextColor.val[1], _plotTextColor.val[2], _plotTextColor.val[3]);
        
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


				// C++:  void render(Mat _plotResult)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_render_10 (IntPtr nativeObj, IntPtr _plotResult_nativeObj);

				// C++:  void setMaxX(double _plotMaxX)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_setMaxX_10 (IntPtr nativeObj, double _plotMaxX);

				// C++:  void setMaxY(double _plotMaxY)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_setMaxY_10 (IntPtr nativeObj, double _plotMaxY);

				// C++:  void setMinX(double _plotMinX)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_setMinX_10 (IntPtr nativeObj, double _plotMinX);

				// C++:  void setMinY(double _plotMinY)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_setMinY_10 (IntPtr nativeObj, double _plotMinY);

				// C++:  void setPlotAxisColor(Scalar _plotAxisColor)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_setPlotAxisColor_10 (IntPtr nativeObj, double _plotAxisColor_val0, double _plotAxisColor_val1, double _plotAxisColor_val2, double _plotAxisColor_val3);

				// C++:  void setPlotBackgroundColor(Scalar _plotBackgroundColor)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_setPlotBackgroundColor_10 (IntPtr nativeObj, double _plotBackgroundColor_val0, double _plotBackgroundColor_val1, double _plotBackgroundColor_val2, double _plotBackgroundColor_val3);

				// C++:  void setPlotGridColor(Scalar _plotGridColor)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_setPlotGridColor_10 (IntPtr nativeObj, double _plotGridColor_val0, double _plotGridColor_val1, double _plotGridColor_val2, double _plotGridColor_val3);

				// C++:  void setPlotLineColor(Scalar _plotLineColor)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_setPlotLineColor_10 (IntPtr nativeObj, double _plotLineColor_val0, double _plotLineColor_val1, double _plotLineColor_val2, double _plotLineColor_val3);

				// C++:  void setPlotLineWidth(int _plotLineWidth)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_setPlotLineWidth_10 (IntPtr nativeObj, int _plotLineWidth);

				// C++:  void setPlotSize(int _plotSizeWidth, int _plotSizeHeight)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_setPlotSize_10 (IntPtr nativeObj, int _plotSizeWidth, int _plotSizeHeight);

				// C++:  void setPlotTextColor(Scalar _plotTextColor)
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_setPlotTextColor_10 (IntPtr nativeObj, double _plotTextColor_val0, double _plotTextColor_val1, double _plotTextColor_val2, double _plotTextColor_val3);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void plot_Plot2d_delete (IntPtr nativeObj);

		}
}
