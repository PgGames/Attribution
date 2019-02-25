
using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEditor.Build;
using System.IO;

namespace Framework.Editor.Tools.AutoBuilder
{
    public class BaseBuilder : EditorWindow
    {
        public bool IsBuduger = false;

        protected string OutBackPath = "";



        public int callbackOrder
        {
            get
            {
                return 0;
            }
        }
        /// <summary>
        /// 切换运行平台
        /// </summary>
        /// <param name="varTarget"></param>
        protected void SwitchApplication(BuildTarget varTarget)
        {
            if (EditorUserBuildSettings.activeBuildTarget != varTarget)
            {
                if (varTarget == BuildTarget.StandaloneWindows || varTarget == BuildTarget.StandaloneWindows64 || varTarget == BuildTarget.StandaloneOSX ||
                    varTarget == BuildTarget.StandaloneLinux || varTarget == BuildTarget.StandaloneLinux64 || varTarget == BuildTarget.StandaloneLinuxUniversal)
                {
                    EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Standalone, varTarget);
                }
                else if (varTarget == BuildTarget.Android)
                {
                    EditorUserBuildSettings.SwitchActiveBuildTargetAsync(BuildTargetGroup.Android, varTarget);
                }
                else if (varTarget == BuildTarget.WebGL)
                {
                    EditorUserBuildSettings.SwitchActiveBuildTargetAsync(BuildTargetGroup.WebGL, varTarget);
                }
                else if (varTarget == BuildTarget.iOS)
                {
                    EditorUserBuildSettings.SwitchActiveBuildTargetAsync(BuildTargetGroup.iOS, varTarget);
                }
            }
            else
            {
                Builder();
            }
        }
        protected void Builder()
        {
            BuildTarget tempBuildTarget = EditorUserBuildSettings.activeBuildTarget;
            SetBuildPath(tempBuildTarget);
            SetBuildEditor(tempBuildTarget);


            SetBuildSetting(tempBuildTarget);
        }

        private void SetBuildPath(BuildTarget varTarget)
        {
            OutBackPath = Application.dataPath;
            if (IsBuduger)
            {
                OutBackPath = OutBackPath.Replace("/Assets", "/Build/Buduger/"); 
            }
            else
            {
                OutBackPath = OutBackPath.Replace("/Assets", "/Build/Official/");
            }
            switch (varTarget)
            {
                case BuildTarget.StandaloneWindows:
                    OutBackPath += "Win32";
                    break;
                case BuildTarget.StandaloneWindows64:
                    OutBackPath += "Win64";
                    break;
                case BuildTarget.StandaloneOSX:
                    break;
                case BuildTarget.iOS:
                    OutBackPath += "Ios";
                    break;
                case BuildTarget.Android:
                    OutBackPath += "Android";
                    break;
                case BuildTarget.StandaloneLinux:
                    break;
                case BuildTarget.WebGL:
                    OutBackPath += "WebGL";
                    break;
                case BuildTarget.WSAPlayer:
                    break;
                case BuildTarget.StandaloneLinux64:
                    break;
                case BuildTarget.StandaloneLinuxUniversal:
                    break;
                case BuildTarget.Tizen:
                    break;
                case BuildTarget.PSP2:
                    break;
                case BuildTarget.PS4:
                    break;
                case BuildTarget.PSM:
                    break;
                case BuildTarget.XboxOne:
                    break;
                case BuildTarget.N3DS:
                    break;
                case BuildTarget.WiiU:
                    break;
                case BuildTarget.tvOS:
                    break;
                case BuildTarget.Switch:
                    break;
                case BuildTarget.NoTarget:
                    break;
                default:
                    break;
            }
            if (!Directory.Exists(OutBackPath))
            {
                Directory.CreateDirectory(OutBackPath);
            }
        }
        /// <summary>
        /// 设置出包的一些设置
        /// </summary>
        /// <param name="varTarget"></param>
        protected virtual void SetBuildEditor(BuildTarget varTarget)
        {
        }
        /// <summary>
        /// 出包设置
        /// </summary>
        /// <param name="varTarget"></param>
        protected virtual void SetBuildSetting(BuildTarget varTarget)
        {
            /*
             * BuildOptions.Development                         //有脚本debug模式
             * 
             * 
             * BuildOptions.StripDebugSymbols                   //（已弃用）
             * BuildOptions.CompressTextures                    //（已弃用）
             * BuildOptions.ForceOptimizeScriptCompilation      //（已弃用）
             * BuildOptions.WebPlayerOfflineDeployment          //（已弃用）
             * 
             * BuildOptions.AutoRunPlayer                       //自动运行包
             * BuildOptions.ShowBuiltPlayer                     //显示出包的文件
             * BuildOptions.BuildAdditionalStreamedScenes       //构建一个压缩资源包
             * BuildOptions.StrictMode                          //在出包过程中如果出现错误将终止出包
             * 
             */
        }
        /// <summary>
        /// 出包
        /// </summary>
        /// <param name="filename">出包文件名</param>
        /// <param name="varOptions">出包信息</param>
        protected void Building(string filename, BuildOptions varOptions)
        {
            int index = (int)varOptions;
            if ((index & (int)BuildOptions.ShowBuiltPlayer) == 0)       //显示出包文件夹
            {
                index += (int)BuildOptions.ShowBuiltPlayer;
            }
            if ((index & (int)BuildOptions.StrictMode) == 0)            //有错误终止出包
            {
                index += (int)BuildOptions.StrictMode;
            }
            if (IsBuduger)
            {
                if ((index & (int)BuildOptions.Development) == 0)       //显示脚本的debug信息
                {
                    index += (int)BuildOptions.Development;
                }
            }
            string content = BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, filename, EditorUserBuildSettings.activeBuildTarget, (BuildOptions)index);
            if (string.IsNullOrEmpty(content))
            {

                Debug.Log("Builder " + Application.productName + " Success");
            }
            else
            {
                Debug.LogError(content);
            }
        }

        public void OnActiveBuildTargetChanged(BuildTarget previousTarget, BuildTarget newTarget)
        {
            Debug.Log("Builder");
            Builder();
        }
    }
}