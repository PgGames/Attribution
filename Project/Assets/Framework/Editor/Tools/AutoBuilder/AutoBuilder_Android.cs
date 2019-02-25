using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Framework.Editor.Tools.AutoBuilder
{
    public class AutoBuilder_Android : BaseBuilder
    {
        private bool IsApk = false;


        internal void Android_Apk()
        {
            IsApk = true;
            SwitchApplication(BuildTarget.Android);

        }
        internal void Android_Grable()
        {
            IsApk = false;
            SwitchApplication(BuildTarget.Android);
        }





        protected override void SetBuildEditor(BuildTarget varTarget)
        {
            if (IsApk)
            {
            }
            else
            {
                //EditorUserBuildSettings.exportAsGoogleAndroidProject = true;
            }
        }
        protected override void SetBuildSetting(BuildTarget varTarget)
        {
            string filename = "";
            int index = (int)BuildOptions.None;
            if (IsApk)
            {
                filename = OutBackPath + "/APK/" + Application.productName + ".apk";
            }
            else
            {
                filename = OutBackPath + "/Grable";
                index += (int)BuildOptions.AcceptExternalModificationsToPlayer;
            }
            

            Building(filename, (BuildOptions)index);
        }
    }
}