# GloveTrackingOpenCV

To get this to run download the Plugins folder from here: https://drive.google.com/open?id=1TVEwTNFiFO4apKwxpBysOQIUdlRkOett

Download this Unity project and open the assets folder, paste the plugins folder into the OpenCVForUnity folder,
now the whole project can be opened in Unity. 
This project uses the native google cardboard functionality in Unity. Android should just work, 
but...
if building out to IOS download CocoaPods and open the pod file in Xcode (this can be found in the IOS build file that gets created from Unity after you hit build). In Xcode go to "build phases" then "link binary with libraries".
Add the "AssetsLibrary.framework" so that OpenCV will run on your iphone.

If you click the top right of the screen a debug menu will appear so you can change the tolerences for different lighting/background conditions. Currently the sending of messages is turned off and it is set to receieve messages. 
