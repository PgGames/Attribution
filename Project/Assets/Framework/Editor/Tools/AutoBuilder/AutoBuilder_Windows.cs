using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEditor.Build;
using System.IO;

namespace Framework.Editor.Tools.AutoBuilder
{
    public class AutoBuilder_Windows : BaseBuilder
    {
        internal bool IsAutoPlayer = false;


        internal void Builder_32()
        {
            SwitchApplication(BuildTarget.StandaloneWindows);
        }
        internal void Builder_64()
        {
            SwitchApplication(BuildTarget.StandaloneWindows64);
        }

        protected override void SetBuildEditor(BuildTarget varTarget)
        {
            PlayerSettings.forceSingleInstance = !IsBuduger;
        }
        protected override void SetBuildSetting(BuildTarget varTarget)
        {
            string filename = OutBackPath + "/" + Application.productName + ".exe";

            int index = (int)BuildOptions.None;
            if (IsAutoPlayer)
            {
                index = (int)BuildOptions.AutoRunPlayer;
                //filename = OutBackPath + "/" + Application.companyName;
                //index += (int)BuildOptions.InstallInBuildFolder;
            }
            Building(filename, (BuildOptions)index);
            
        }
    }
}