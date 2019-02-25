
using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using UnityEngine.Events;
using System;

namespace Framework.Editor.Tools.Modules
{
    public class Tools_Module : WindowBaseEditor<Tools_Module>
    {
        [MenuItem("Tools/Create Module", priority = 9)]
        static void CreatorModule()
        {
            s_instance = null;
            instance.titleContent = new GUIContent("Create Module");
            instance.Show();
        }

        private void OnEnable()
        {
            m_ModuleInfo = Tools_Public.ReadDate<ModuleDate>("ModuleInfo");
            if (m_ModuleInfo == null)
            {
                m_ModuleInfo = new ModuleDate();
                m_ModuleInfo.Init();
            }
        }
        private void OnDisable()
        {
            Tools_Public.SaveDate("ModuleInfo", m_ModuleInfo);
        }

        private void OnGUI()
        {
            CreateModuleUI();
        }
        internal static ModuleDate m_ModuleInfo = new ModuleDate();
        private Vector2 m_ScrollPosition;
        private void CreateModuleUI()
        {
            if (string.IsNullOrEmpty(m_ModuleInfo.ModulePath))
            {
                m_ModuleInfo.Init();
            }
            m_ScrollPosition =  EditorGUILayout.BeginScrollView(m_ScrollPosition);
            GUILayout.BeginVertical();
            EditorGUILayout.Space();

            //文件信息
            using (new EditorGUI.DisabledScope())
            {
                m_ModuleInfo.ModulePath = EditorGUILayout.TextField("Folder Path", m_ModuleInfo.ModulePath);
                GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("OpenFile", GUILayout.MaxWidth(Tools_Public.Tools_MinButtonWidth)))
                {
                    var newPath = EditorUtility.OpenFolderPanel("OpenFile", Application.dataPath, "");
                    if (!string.IsNullOrEmpty(newPath))
                    {
                        newPath = newPath.Replace("\\", "/");
                        var temppath = Application.dataPath.Replace("\\", "/");
                        if (newPath.Contains(temppath))
                        {
                            m_ModuleInfo.ModulePath = newPath.Replace(temppath, "");
                            m_ModuleInfo.ModulePath = m_ModuleInfo.ModulePath.TrimStart('/');
                        }
                    }
                }
                if (GUILayout.Button("UpDate", GUILayout.MaxWidth(Tools_Public.Tools_MinButtonWidth)))
                {
                    m_ModuleInfo.Init();
                }
                GUILayout.EndHorizontal();
            }
            //模块信息
            using (new EditorGUI.DisabledScope())
            {
                EditorGUILayout.Space();
                m_ModuleInfo.ModuleName = EditorGUILayout.TextField("Module Name", m_ModuleInfo.ModuleName);
                if (Tools_Public.RightButton("Switch Module", GUILayout.Width(Tools_Public.Tools_ButtonWidth)))
                {
                    SwitchModule();
                }
                m_ModuleInfo.ModuleTips = EditorGUILayout.TextField("Module Tips", m_ModuleInfo.ModuleTips);
                m_ModuleInfo.IsVideoPlayer = EditorGUILayout.Toggle("VideoPlayer", m_ModuleInfo.IsVideoPlayer);
                m_ModuleInfo.IsAnimations = EditorGUILayout.Toggle("Animations", m_ModuleInfo.IsAnimations);
                m_ModuleInfo.IsAudioClip = EditorGUILayout.Toggle("AudioClip", m_ModuleInfo.IsAudioClip);
                m_ModuleInfo.IsTexture = EditorGUILayout.Toggle("Texture", m_ModuleInfo.IsTexture);
                m_ModuleInfo.IsShader = EditorGUILayout.Toggle("Shader", m_ModuleInfo.IsShader);
                m_ModuleInfo.IsUI = EditorGUILayout.Toggle("UI", m_ModuleInfo.IsUI);
                m_ModuleInfo.IsTxt = EditorGUILayout.Toggle("Txt", m_ModuleInfo.IsTxt);
            }

            //创建模块
            using (new EditorGUI.DisabledScope())
            {
                if (Tools_Public.CenterButton("Create Module", GUILayout.MaxWidth(Tools_Public.Tools_MaxButtonWidth)))
                {
                    string temp_path = Application.dataPath + "/" + m_ModuleInfo.ModulePath;
                    CreateFolder(temp_path, m_ModuleInfo.ModuleName, m_ModuleInfo.ModuleTips);
                }
            }
            GUILayout.EndVertical();
            EditorGUILayout.EndScrollView();
        }


        private void SwitchModule()
        {
            string module = Application.dataPath + "/" + m_ModuleInfo.ModulePath;
            string modulepath = EditorUtility.OpenFolderPanel("Switch Module", module, "");
            if (!string.IsNullOrEmpty(modulepath))
            {
                if (!(Directory.Exists(modulepath + "/Resources") && Directory.Exists(modulepath + "/Scripts") && Directory.Exists(modulepath + "/Scenes")))
                {
                    EditorUtility.DisplayDialog("Switch Module", "This Is Not Module Folder", "Clsoe");
                    return;
                }
                string explain = "";
                if (File.Exists(modulepath + "/explain.txt"))
                {
                    explain = File.ReadAllText(modulepath + "/explain.txt");
                }
                module = module.Replace("\\","/");
                modulepath = modulepath.Replace("\\", "/");
                string modulename = modulepath.Replace(module, "");
                modulename = modulename.TrimStart('/');

                m_ModuleInfo.ModuleName = modulename;
                m_ModuleInfo.ModuleTips = explain;
            }
        }

        /// <summary>
        /// 创建模块信息
        /// </summary>
        /// <param name="varPath"></param>
        /// <param name="varName"></param>
        /// <param name="varTips"></param>
        private void CreateFolder(string varPath,string varName,string varTips)
        {
            string message = null;
            try
            {
                if (string.IsNullOrEmpty(varPath))
                {
                    message = "Create Module Fail, Folder Path Can't Null";
                    return;
                }
                if (string.IsNullOrEmpty(varName))
                {
                    message = "Create Module Fail, Module Name Can't Null";
                    return;
                }
                else
                {
                    varName = varName.Replace(" ", "");
                }
                if (string.IsNullOrEmpty(varTips))
                {
                    message = "Create Module Fail, Module Tips Can't Null";
                    return;
                }
                string tempPath = varPath + "/" + varName;

                CreateFolderAndTxt(varPath, varName, varTips);

                if (m_ModuleInfo.IsAnimations)
                {
                    CreateFolderAndTxt(tempPath, "Animations", "这个文件夹用来放动画文件\n自己做的动画");
                }
                if (m_ModuleInfo.IsShader)
                {
                    CreateFolderAndTxt(tempPath, "Shader", "这个文件夹用来放Shader文件");
                }
                if (m_ModuleInfo.IsAudioClip)
                {
                    CreateFolderAndTxt(tempPath, "AudioClip", "这个文件夹用来放音频文件");
                }
                if (m_ModuleInfo.IsVideoPlayer)
                {
                    CreateFolderAndTxt(tempPath, "VideoPlayer", "这个文件夹用来放视频文件");
                }
                if (m_ModuleInfo.IsTxt)
                {
                    CreateFolderAndTxt(tempPath, "Txt", "这个文件夹用来放文本文件");
                }
                if (m_ModuleInfo.IsUI)
                {
                    CreateFolderAndTxt(tempPath, "Resources/" + varName + "/UI/Prefabs", null);
                    CreateFolderAndTxt(tempPath, "Scripts/UI", "这个文件夹用来放模块中的UI脚本");
                    CreateFolderAndTxt(tempPath, "Sprites", "这个文件夹用来放UI图片");
                }
                if (m_ModuleInfo.IsTexture)
                {
                    CreateFolderAndTxt(tempPath, "Texture", "这个文件夹用来放贴图");
                }

                CreateFolderAndTxt(tempPath, "Materials", "这个文件夹用来放材质球");
                CreateFolderAndTxt(tempPath, "Models", "这个文件夹用来放模型");

                CreateFolderAndTxt(tempPath, "Prefabs", "这个文件夹用来放不需要放在Resources文件加下的预制");

                CreateFolderAndTxt(tempPath, "Resources/" + varName + "/Prefabs", null);
                CreateFolderAndTxt(tempPath, "Scripts", "这个文件夹用来放脚本按功能划分文件夹\n脚本统一按模块名称进行设置命名空间");

                CreateFolderAndTxt(tempPath, "Scenes", "这个文件夹用来放场景");

                //刷新资源
                AssetDatabase.Refresh();
                message = "Create " + varName + " Module Success";
            }
            catch(System.Exception exp)
            {
                Debug.LogError(exp);
                message = "Create " + varName + " Module Failure ";
            }
            finally
            {
                EditorUtility.DisplayDialog("Create Module", message, "Clsoe");
            }
        }
        /// <summary>
        /// 创建文件夹和描述
        /// </summary>
        /// <param name="varPath"></param>
        /// <param name="varName"></param>
        /// <param name="varContent"></param>
        private void CreateFolderAndTxt(string varPath,string varName,string varContent)
        {
            if (string.IsNullOrEmpty(varPath) || string.IsNullOrEmpty(varName))
                return;
            Directory.CreateDirectory(varPath+"/"+varName);
            if (!string.IsNullOrEmpty(varContent))
            {
                var tempstream = File.CreateText(varPath + "/" + varName + "/explain.txt");
                tempstream.Write(varContent);
                tempstream.Close();
            }
        }

        [Serializable]
        public class ModuleDate : BaseDate
        {
            public string ModulePath;
            public string ModuleName;
            public string ModuleTips;
            public bool IsAnimations;
            public bool IsVideoPlayer;
            public bool IsAudioClip;
            public bool IsTexture;
            public bool IsShader;
            public bool IsTxt;
            public bool IsUI;

            public ModuleDate()
            {
            }

            public void Init()
            {
                ModulePath = Application.dataPath + "/Project Module";
                ModuleName = null;
                ModuleTips = null;
            }
        }
    }
}