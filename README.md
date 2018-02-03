# GloveTrackingOpenCV

To get this to run download the Plugins folder from here: https://drive.google.com/open?id=1TVEwTNFiFO4apKwxpBysOQIUdlRkOett

Download this Unity project and open the assets folder, paste the plugins folder into the OpenCVForUnity folder,
now the whole project can be opened in Unity. 
This project uses the native google cardboard functionality in Unity. Android should just work, 
but...
if building out to IOS download CocoaPods and open the pod file in Xcode. Go to "build phases" then "link binary with libraries".
Add the "AssetsLibrary.framework" so that OpenCV will run on your iphone. 
