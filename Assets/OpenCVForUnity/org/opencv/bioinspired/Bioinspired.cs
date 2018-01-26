
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class Bioinspired
		{

				public const int RETINA_COLOR_RANDOM = 0;
				public const int RETINA_COLOR_DIAGONAL = 1;
				public const int RETINA_COLOR_BAYER = 2;



				//
				// C++:  Ptr_Retina createRetina(Size inputSize, bool colorMode, int colorSamplingMethod = RETINA_COLOR_BAYER, bool useRetinaLogSampling = false, float reductionFactor = 1.0f, float samplingStrenght = 10.0f)
				//

				//javadoc: createRetina(inputSize, colorMode, colorSamplingMethod, useRetinaLogSampling, reductionFactor, samplingStrenght)
				public static Retina createRetina (Size inputSize, bool colorMode, int colorSamplingMethod, bool useRetinaLogSampling, float reductionFactor, float samplingStrenght)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Retina retVal = new Retina(bioinspired_Bioinspired_createRetina_10(inputSize.width, inputSize.height, colorMode, colorSamplingMethod, useRetinaLogSampling, reductionFactor, samplingStrenght));
        
        return retVal;
#else
						return null;
#endif
				}

				//javadoc: createRetina(inputSize, colorMode)
				public static Retina createRetina (Size inputSize, bool colorMode)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Retina retVal = new Retina(bioinspired_Bioinspired_createRetina_11(inputSize.width, inputSize.height, colorMode));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  Ptr_Retina createRetina(Size inputSize)
				//

				//javadoc: createRetina(inputSize)
				public static Retina createRetina (Size inputSize)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Retina retVal = new Retina(bioinspired_Bioinspired_createRetina_12(inputSize.width, inputSize.height));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  Ptr_RetinaFastToneMapping createRetinaFastToneMapping(Size inputSize)
				//

				//javadoc: createRetinaFastToneMapping(inputSize)
				public static RetinaFastToneMapping createRetinaFastToneMapping (Size inputSize)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        RetinaFastToneMapping retVal = new RetinaFastToneMapping(bioinspired_Bioinspired_createRetinaFastToneMapping_10(inputSize.width, inputSize.height));
        
        return retVal;
#else
						return null;
#endif
				}


				//
				// C++:  Ptr_TransientAreasSegmentationModule createTransientAreasSegmentationModule(Size inputSize)
				//

				//javadoc: createTransientAreasSegmentationModule(inputSize)
				public static TransientAreasSegmentationModule createTransientAreasSegmentationModule (Size inputSize)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        TransientAreasSegmentationModule retVal = new TransientAreasSegmentationModule(bioinspired_Bioinspired_createTransientAreasSegmentationModule_10(inputSize.width, inputSize.height));
        
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

				// C++:  Ptr_Retina createRetina(Size inputSize, bool colorMode, int colorSamplingMethod = RETINA_COLOR_BAYER, bool useRetinaLogSampling = false, float reductionFactor = 1.0f, float samplingStrenght = 10.0f)
				[DllImport(LIBNAME)]
				private static extern IntPtr bioinspired_Bioinspired_createRetina_10 (double inputSize_width, double inputSize_height, bool colorMode, int colorSamplingMethod, bool useRetinaLogSampling, float reductionFactor, float samplingStrenght);

				[DllImport(LIBNAME)]
				private static extern IntPtr bioinspired_Bioinspired_createRetina_11 (double inputSize_width, double inputSize_height, bool colorMode);

				// C++:  Ptr_Retina createRetina(Size inputSize)
				[DllImport(LIBNAME)]
				private static extern IntPtr bioinspired_Bioinspired_createRetina_12 (double inputSize_width, double inputSize_height);

				// C++:  Ptr_RetinaFastToneMapping createRetinaFastToneMapping(Size inputSize)
				[DllImport(LIBNAME)]
				private static extern IntPtr bioinspired_Bioinspired_createRetinaFastToneMapping_10 (double inputSize_width, double inputSize_height);

				// C++:  Ptr_TransientAreasSegmentationModule createTransientAreasSegmentationModule(Size inputSize)
				[DllImport(LIBNAME)]
				private static extern IntPtr bioinspired_Bioinspired_createTransientAreasSegmentationModule_10 (double inputSize_width, double inputSize_height);

		}
}
