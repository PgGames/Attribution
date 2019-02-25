using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Framework.Editor.Tools.FileTemplate
{
    public class File_Setting : WindowBase
    {
        Tools_FileTemplate m_Date;

        internal override void OnEnable(EditorWindow varWindow)
        {
            m_Date = varWindow as Tools_FileTemplate;
            if (m_Date == null)
            {
                m_Date = Tools_FileTemplate.instance;
            }
        }


        const float k_ToolbarPadding = 15f;
        const float k_ToolButtonspacing = 5f;
        const float k_ButtonSingleWidth = 20f;
        const float k_AddButtonWidth = 100f;
        internal override void OnGUI()
        {
            EditorGUILayout.Space();
            //Copyright
            using (new EditorGUI.DisabledScope())
            {
                m_Date.m_TabData.m_CopyrightName = EditorGUILayout.TextField("CopyrightName", m_Date.m_TabData.m_CopyrightName);

                m_Date.m_TabData.m_UserCopyright = EditorGUILayout.Toggle("IsCopyright", m_Date.m_TabData.m_UserCopyright);
            }
            //using
            using (new EditorGUI.DisabledScope())
            {
                EditorGUILayout.Space();
                GUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Using Namespace");
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("+", GUILayout.Width(k_ButtonSingleWidth)))
                {
                    m_Date.m_TabData.m_UsingNamespace.Add("");
                }
                GUILayout.EndHorizontal();
                for (int i = 0; i < m_Date.m_TabData.m_UsingNamespace.Count; i++)
                {
                    GUILayout.BeginHorizontal();
                    m_Date.m_TabData.m_UsingNamespace[i] = EditorGUILayout.TextField(m_Date.m_TabData.m_UsingNamespace[i]);
                    if (GUILayout.Button("-", GUILayout.Width(k_ButtonSingleWidth)))
                    {
                        Debug.Log("Remove " + m_Date.m_TabData.m_UsingNamespace[i]);
                        m_Date.m_TabData.m_UsingNamespace.RemoveAt(i);
                    }
                    GUILayout.EndHorizontal();
                }
            }
            //namespace
            using (new EditorGUI.DisabledScope())
            {
                EditorGUILayout.Space();
                m_Date.m_TabData.m_Namespace = EditorGUILayout.Toggle("NameSpace", m_Date.m_TabData.m_Namespace);
            }
            //module
            using (new EditorGUI.DisabledScope())
            {
                EditorGUILayout.Space();
                GUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("module info");
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("+", GUILayout.Width(k_ButtonSingleWidth)))
                {
                    m_Date.m_TabData.m_ModuleInfo.Add(new Tools_FileTemplate.ModuleInfo());
                }
                GUILayout.EndHorizontal();
                for (int i = 0; i < m_Date.m_TabData.m_ModuleInfo.Count; i++)
                {
                    GUILayout.BeginHorizontal();
                    var tempModuleinfo = m_Date.m_TabData.m_ModuleInfo[i];
                    tempModuleinfo.Name = EditorGUILayout.TextField("\u3000module Name", tempModuleinfo.Name);
                    if (i != 0)
                    {
                        if (GUILayout.Button("↑", GUILayout.Width(k_ButtonSingleWidth)))
                        {
                            ReplaceListContent(m_Date.m_TabData.m_ModuleInfo, i, i - 1);
                        }
                    }
                    else
                    {
                        GUILayout.Label("", GUILayout.Width(k_ButtonSingleWidth));
                    }
                    if (i != m_Date.m_TabData.m_ModuleInfo.Count - 1)
                    {
                        if (GUILayout.Button("↓", GUILayout.Width(k_ButtonSingleWidth)))
                        {
                            ReplaceListContent(m_Date.m_TabData.m_ModuleInfo, i, i + 1);
                        }
                    }
                    else
                    {
                        GUILayout.Label("", GUILayout.Width(k_ButtonSingleWidth));
                    }
                    if (GUILayout.Button("Add Method", GUILayout.Width(k_AddButtonWidth)))
                    {
                        if (tempModuleinfo.m_Methods == null)
                        {
                            tempModuleinfo.m_Methods = new List<string>();
                        }
                        tempModuleinfo.m_Methods.Add("");
                    }
                    if (GUILayout.Button("-", GUILayout.Width(k_ButtonSingleWidth)))
                    {
                        m_Date.m_TabData.m_ModuleInfo.RemoveAt(i);
                    }
                    GUILayout.EndHorizontal();


                    //module -> Methods
                    if (tempModuleinfo.m_Methods != null)
                    {
                        for (int j = 0; j < tempModuleinfo.m_Methods.Count; j++)
                        {
                            GUILayout.BeginHorizontal();
                            tempModuleinfo.m_Methods[j] = EditorGUILayout.TextField("\u3000\u3000method Name", tempModuleinfo.m_Methods[j]);

                            if (j != 0)
                            {
                                if (GUILayout.Button("↑", GUILayout.Width(k_ButtonSingleWidth)))
                                {
                                    ReplaceListContent(tempModuleinfo.m_Methods, j, j - 1);
                                    //string tempCurrent = tempModuleinfo.m_Methods[j];
                                    //string tempIndex = tempModuleinfo.m_Methods[j - 1];
                                    //tempModuleinfo.m_Methods[j] = tempIndex;
                                    //tempModuleinfo.m_Methods[j - 1] = tempCurrent;
                                }
                            }
                            else
                            {
                                GUILayout.Label("", GUILayout.Width(k_ButtonSingleWidth));
                            }
                            if (j != tempModuleinfo.m_Methods.Count - 1)
                            {
                                if (GUILayout.Button("↓", GUILayout.Width(k_ButtonSingleWidth)))
                                {
                                    ReplaceListContent(tempModuleinfo.m_Methods, j, j + 1);
                                }
                            }
                            else
                            {
                                GUILayout.Label("", GUILayout.Width(k_ButtonSingleWidth));
                            }
                            if (GUILayout.Button("-", GUILayout.Width(k_ButtonSingleWidth)))
                            {
                                m_Date.m_TabData.m_ModuleInfo[i].m_Methods.RemoveAt(j);
                            }
                            GUILayout.EndHorizontal();
                        }
                    }
                }
            }
        }
        void ReplaceListContent<T>(List<T> array, int startidx, int endidx)
        {
            var tempstart = array[startidx];
            array[startidx] = array[endidx];
            array[endidx] = tempstart;
        }
    }
}