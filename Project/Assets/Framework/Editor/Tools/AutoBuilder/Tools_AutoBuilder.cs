
using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEditor.Build;

namespace Framework.Editor.Tools.AutoBuilder
{
    public class Tools_AutoBuilder : EditorWindow, IActiveBuildTargetChanged
    {
        //private static AutoBuilder_Windows _Windows;
        //private static AutoBuilder_Android _Android;
        //private static AutoBuilder_Web _Web;

        private static BaseBuilder baseBuilder;

        private static Tools_AutoBuilder s_instance = null;



        internal static Tools_AutoBuilder instance
        {
            get
            {
                if (s_instance == null)
                    s_instance = GetWindow<Tools_AutoBuilder>();
                return s_instance;
            }
        }
        public int callbackOrder { get { return 1; } }

        [MenuItem("Tools/Auto Builder/Windows/32", priority = 1001)]
        internal static void Official_Windows32()
        {
            AutoBuilder_Windows temp_Windows = new AutoBuilder_Windows();
            baseBuilder = temp_Windows;
            temp_Windows.Builder_32();
        }
        [MenuItem("Tools/Auto Builder/Windows/64", priority = 1002)]
        internal static void Official_Windows64()
        {
            AutoBuilder_Windows temp_Windows = new AutoBuilder_Windows();
            baseBuilder = temp_Windows;
            temp_Windows.Builder_64();
        }
        [MenuItem("Tools/Auto Builder/Android/Apk", priority = 1001)]
        internal static void Official_Android_Apk()
        {
            AutoBuilder_Android temp_Android = new AutoBuilder_Android();
            baseBuilder = temp_Android;
            temp_Android.Android_Apk();
        }
        [MenuItem("Tools/Auto Builder/Android/Grable", priority = 1002)]
        internal static void Official_Android_Grable()
        {
            AutoBuilder_Android temp_Android = new AutoBuilder_Android();
            baseBuilder = temp_Android;
            temp_Android.Android_Grable();
        }
        [MenuItem("Tools/Auto Builder/Web/WebGL", priority = 1001)]
        internal static void Official_WebGL()
        {
            AutoBuilder_Web temp_Web = new AutoBuilder_Web();
            baseBuilder = temp_Web;
            temp_Web.WebGL();
        }
        [MenuItem("Tools/Auto Builder/iOS", priority = 1002)]
        internal static void Official_IOS()
        {
            AutoBuilder_Ios temp_Ios = new AutoBuilder_Ios();
            baseBuilder = temp_Ios;
            temp_Ios.Ios();
        }









        [MenuItem("Tools/Auto Builder Buduger/Windows/32", priority = 2001)]
        internal static void Demo_Windows32()
        {
            AutoBuilder_Windows temp_Windows = new AutoBuilder_Windows();
            baseBuilder = temp_Windows;
            temp_Windows.IsBuduger = true;
            temp_Windows.Builder_32();
        }
        [MenuItem("Tools/Auto Builder Buduger/Windows/64", priority = 2002)]
        internal static void Demo_Windows64()
        {
            AutoBuilder_Windows temp_Windows = new AutoBuilder_Windows();
            baseBuilder = temp_Windows;
            temp_Windows.IsBuduger = true;
            temp_Windows.Builder_64();
        }
        [MenuItem("Tools/Auto Builder Buduger/Windows/AutoPlay32", priority = 2003)]
        internal static void Demo_AutoPlay_Windows32()
        {
            AutoBuilder_Windows temp_Windows = new AutoBuilder_Windows();
            baseBuilder = temp_Windows;
            temp_Windows.IsAutoPlayer = true;
            temp_Windows.IsBuduger = true;
            temp_Windows.Builder_32();
        }
        [MenuItem("Tools/Auto Builder Buduger/Windows/AutoPlay64", priority = 2004)]
        internal static void Demo_AutoPlay_Windows64()
        {
            AutoBuilder_Windows temp_Windows = new AutoBuilder_Windows();
            baseBuilder = temp_Windows;
            temp_Windows.IsAutoPlayer = true;
            temp_Windows.IsBuduger = true;
            temp_Windows.Builder_64();
        }
        [MenuItem("Tools/Auto Builder Buduger/Android/Apk", priority = 2001)]
        internal static void Demo_Android_Apk()
        {
            AutoBuilder_Android temp_Android = new AutoBuilder_Android();
            baseBuilder = temp_Android;
            temp_Android.IsBuduger = true;
            temp_Android.Android_Apk();
        }
        [MenuItem("Tools/Auto Builder Buduger/Android/Grable", priority = 2002)]
        internal static void Demo_Android_Grable()
        {
            AutoBuilder_Android temp_Android = new AutoBuilder_Android();
            baseBuilder = temp_Android;
            temp_Android.IsBuduger = true;
            temp_Android.Android_Grable();
        }
        [MenuItem("Tools/Auto Builder Buduger/Web/WebGL", priority = 2001)]
        internal static void Demo_WebGL()
        {
            AutoBuilder_Web temp_Web = new AutoBuilder_Web();
            baseBuilder = temp_Web;
            temp_Web.IsBuduger = true;
            temp_Web.WebGL();
        }
        [MenuItem("Tools/Auto Builder Buduger/iOS", priority = 2004)]
        internal static void Demo_IOS()
        {
            AutoBuilder_Ios temp_Ios = new AutoBuilder_Ios();
            baseBuilder = temp_Ios;
            temp_Ios.IsBuduger = true;
            temp_Ios.Ios();
        }




        private static BaseBuilder GetBaseBuilder()
        {
            baseBuilder = new BaseBuilder();
            return baseBuilder;
        }

        public void OnActiveBuildTargetChanged(BuildTarget previousTarget, BuildTarget newTarget)
        {
            if (baseBuilder != null)
            {
                baseBuilder.OnActiveBuildTargetChanged(previousTarget, newTarget);
            }
        }
    }
}