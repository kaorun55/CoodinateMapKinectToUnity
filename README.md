CoodinateMapKinectToUnity
=========================

Kinectのカメラ座標系をUnityのワールド座標系に変換する

 * https://www.youtube.com/watch?v=N2fdF4p4uy0
 * Assets\Scenes\CoodinateSample.unity を参照してください。

## 環境

 * Unity Pro 4.5.4f1
 * Kinect for Windows v2
 * Kinect for Windows SDK v2 1408 + 1407 Unity pakage
 * Visual Studio 2013 Ultimate

## 既知の問題

 * KinectのColor座標系のみ対応
 * コード上はDepth座標系にも対応させたが、Unityのワールド座標系に変換するカメラがColorの解像度になっている(自動でDepthの解像度に合わせられると嬉しい)
 * 中心よりも右側で座標が飛ぶ
