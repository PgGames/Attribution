using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Framework.Editor.Tools.AutoBuilder
{
    public class AutoBuilder_Web : BaseBuilder
    {
        internal void WebGL()
        {
            SwitchApplication(BuildTarget.WebGL);
        }



        protected override void SetBuildSetting(BuildTarget varTarget)
        {
            string filename = "";
            int index = (int)BuildOptions.None;
            filename = OutBackPath + "/" + Application.productName;


            Building(filename, (BuildOptions)index);
        }
    }
}