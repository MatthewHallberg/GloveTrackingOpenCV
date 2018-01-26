
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{



// C++: class Algorithm
/**
 * <p>class CV_EXPORTS_W Algorithm <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>public:</p>
 *
 * <p>Algorithm();</p>
 *
 * <p>virtual ~Algorithm();</p>
 *
 * <p>string name() const;</p>
 *
 * <p>template<typename _Tp> typename ParamType<_Tp>.member_type get(const string&
 * name) const;</p>
 *
 * <p>template<typename _Tp> typename ParamType<_Tp>.member_type get(const char*
 * name) const;</p>
 *
 * <p>CV_WRAP int getInt(const string& name) const;</p>
 *
 * <p>CV_WRAP double getDouble(const string& name) const;</p>
 *
 * <p>CV_WRAP bool getBool(const string& name) const;</p>
 *
 * <p>CV_WRAP string getString(const string& name) const;</p>
 *
 * <p>CV_WRAP Mat getMat(const string& name) const;</p>
 *
 * <p>CV_WRAP vector<Mat> getMatVector(const string& name) const;</p>
 *
 * <p>CV_WRAP Ptr<Algorithm> getAlgorithm(const string& name) const;</p>
 *
 * <p>void set(const string& name, int value);</p>
 *
 * <p>void set(const string& name, double value);</p>
 *
 * <p>void set(const string& name, bool value);</p>
 *
 * <p>void set(const string& name, const string& value);</p>
 *
 * <p>void set(const string& name, const Mat& value);</p>
 *
 * <p>void set(const string& name, const vector<Mat>& value);</p>
 *
 * <p>void set(const string& name, const Ptr<Algorithm>& value);</p>
 *
 * <p>template<typename _Tp> void set(const string& name, const Ptr<_Tp>& value);</p>
 *
 * <p>CV_WRAP void setInt(const string& name, int value);</p>
 *
 * <p>CV_WRAP void setDouble(const string& name, double value);</p>
 *
 * <p>CV_WRAP void setBool(const string& name, bool value);</p>
 *
 * <p>CV_WRAP void setString(const string& name, const string& value);</p>
 *
 * <p>CV_WRAP void setMat(const string& name, const Mat& value);</p>
 *
 * <p>CV_WRAP void setMatVector(const string& name, const vector<Mat>& value);</p>
 *
 * <p>CV_WRAP void setAlgorithm(const string& name, const Ptr<Algorithm>& value);</p>
 *
 * <p>template<typename _Tp> void setAlgorithm(const string& name, const Ptr<_Tp>&
 * value);</p>
 *
 * <p>void set(const char* name, int value);</p>
 *
 * <p>void set(const char* name, double value);</p>
 *
 * <p>void set(const char* name, bool value);</p>
 *
 * <p>void set(const char* name, const string& value);</p>
 *
 * <p>void set(const char* name, const Mat& value);</p>
 *
 * <p>void set(const char* name, const vector<Mat>& value);</p>
 *
 * <p>void set(const char* name, const Ptr<Algorithm>& value);</p>
 *
 * <p>template<typename _Tp> void set(const char* name, const Ptr<_Tp>& value);</p>
 *
 * <p>void setInt(const char* name, int value);</p>
 *
 * <p>void setDouble(const char* name, double value);</p>
 *
 * <p>void setBool(const char* name, bool value);</p>
 *
 * <p>void setString(const char* name, const string& value);</p>
 *
 * <p>void setMat(const char* name, const Mat& value);</p>
 *
 * <p>void setMatVector(const char* name, const vector<Mat>& value);</p>
 *
 * <p>void setAlgorithm(const char* name, const Ptr<Algorithm>& value);</p>
 *
 * <p>template<typename _Tp> void setAlgorithm(const char* name, const Ptr<_Tp>&
 * value);</p>
 *
 * <p>CV_WRAP string paramHelp(const string& name) const;</p>
 *
 * <p>int paramType(const char* name) const;</p>
 *
 * <p>CV_WRAP int paramType(const string& name) const;</p>
 *
 * <p>CV_WRAP void getParams(CV_OUT vector<string>& names) const;</p>
 *
 * <p>virtual void write(FileStorage& fs) const;</p>
 *
 * <p>virtual void read(const FileNode& fn);</p>
 *
 * <p>typedef Algorithm* (*Constructor)(void);</p>
 *
 * <p>typedef int (Algorithm.*Getter)() const;</p>
 *
 * <p>typedef void (Algorithm.*Setter)(int);</p>
 *
 * <p>CV_WRAP static void getList(CV_OUT vector<string>& algorithms);</p>
 *
 * <p>CV_WRAP static Ptr<Algorithm> _create(const string& name);</p>
 *
 * <p>template<typename _Tp> static Ptr<_Tp> create(const string& name);</p>
 *
 * <p>virtual AlgorithmInfo* info() const / * TODO: make it = 0;* / { return 0; }</p>
 *
 * <p>};</p>
 *
 * <p>This is a base class for all more or less complex algorithms in OpenCV,
 * especially for classes of algorithms, for which there can be multiple
 * implementations. The examples are stereo correspondence (for which there are
 * algorithms like block matching, semi-global block matching, graph-cut etc.),
 * background subtraction (which can be done using mixture-of-gaussians models,
 * codebook-based algorithm etc.), optical flow (block matching, Lucas-Kanade,
 * Horn-Schunck etc.).
 * </code></p>
 *
 * <p>The class provides the following features for all derived classes:</p>
 * <ul>
 *   <li> so called "virtual constructor". That is, each Algorithm derivative is
 * registered at program start and you can get the list of registered algorithms
 * and create instance of a particular algorithm by its name (see
 * <code>Algorithm.create</code>). If you plan to add your own algorithms, it
 * is good practice to add a unique prefix to your algorithms to distinguish
 * them from other algorithms.
 *   <li> setting/retrieving algorithm parameters by name. If you used video
 * capturing functionality from OpenCV highgui module, you are probably familar
 * with <code>cvSetCaptureProperty()</code>, <code>cvGetCaptureProperty()</code>,
 * <code>VideoCapture.set()</code> and <code>VideoCapture.get()</code>.
 * <code>Algorithm</code> provides similar method where instead of integer id's
 * you specify the parameter names as text strings. See <code>Algorithm.set</code>
 * and <code>Algorithm.get</code> for details.
 *   <li> reading and writing parameters from/to XML or YAML files. Every
 * Algorithm derivative can store all its parameters and then read them back.
 * There is no need to re-implement it each time.
 * </ul>
 * <p>Here is example of SIFT use in your application via Algorithm interface:
 * <code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>#include "opencv2/opencv.hpp"</p>
 *
 * <p>#include "opencv2/nonfree/nonfree.hpp"...</p>
 *
 * <p>initModule_nonfree(); // to load SURF/SIFT etc.</p>
 *
 * <p>Ptr<Feature2D> sift = Algorithm.create<Feature2D>("Feature2D.SIFT");</p>
 *
 * <p>FileStorage fs("sift_params.xml", FileStorage.READ);</p>
 *
 * <p>if(fs.isOpened()) // if we have file with parameters, read them</p>
 *
 *
 * <p>sift->read(fs["sift_params"]);</p>
 *
 * <p>fs.release();</p>
 *
 *
 * <p>else // else modify the parameters and store them; user can later edit the
 * file to use different parameters</p>
 *
 *
 * <p>sift->set("contrastThreshold", 0.01f); // lower the contrast threshold,
 * compared to the default value</p>
 *
 *
 * <p>WriteStructContext ws(fs, "sift_params", CV_NODE_MAP);</p>
 *
 * <p>sift->write(fs);</p>
 *
 *
 *
 * <p>Mat image = imread("myimage.png", 0), descriptors;</p>
 *
 * <p>vector<KeyPoint> keypoints;</p>
 *
 * <p>(*sift)(image, noArray(), keypoints, descriptors);</p>
 *
 * @see <a href="http://docs.opencv.org/modules/core/doc/basic_structures.html#algorithm">org.opencv.core.Algorithm</a>
 */
		public class Algorithm : DisposableOpenCVObject
		{



				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												core_Algorithm_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
						return;
						#endif
				}
	
				protected Algorithm (IntPtr addr) : base(addr)
				{

				}


	
	
				//
				// C++:  String getDefaultName()
				//
		
				//javadoc: Algorithm::getDefaultName()
				public  string getDefaultName ()
				{
						ThrowIfDisposed ();
			
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
			string retVal = Marshal.PtrToStringAnsi (core_Algorithm_getDefaultName_10 (nativeObj));
			
			return retVal;
						#else
						return null;
						#endif
				}
		
		
				//
				// C++:  void clear()
				//
		
				//javadoc: Algorithm::clear()
				public  void clear ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						core_Algorithm_clear_10 (nativeObj);
			
						return;
						#else
						return;
						#endif
				}
		
		
				//
				// C++:  void save(String filename)
				//
		
				//javadoc: Algorithm::save(filename)
				public virtual void save (string filename)
				{
						ThrowIfDisposed ();
			
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						core_Algorithm_save_10 (nativeObj, filename);
			
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

		
				// C++:  String getDefaultName()
				[DllImport(LIBNAME)]
				private static extern IntPtr core_Algorithm_getDefaultName_10 (IntPtr nativeObj);

				// C++:  void clear()
				[DllImport(LIBNAME)]
				private static extern void core_Algorithm_clear_10 (IntPtr nativeObj);
		
				// C++:  void save(String filename)
				[DllImport(LIBNAME)]
				private static extern void core_Algorithm_save_10 (IntPtr nativeObj, string filename);

				// native support for java finalize()
				[DllImport(LIBNAME)]
				private static extern void core_Algorithm_delete (IntPtr nativeObj);

	
		}
}
