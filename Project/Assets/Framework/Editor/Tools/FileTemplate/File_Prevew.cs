using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Text;

namespace Framework.Editor.Tools.FileTemplate
{
    public class File_Prevew 
    {
        Tools_FileTemplate m_Date;


        internal void OnEnable(EditorWindow varWindow)
        {
            m_Date = varWindow as Tools_FileTemplate;
        }


        internal void OnGUI()
        {
            EditorGUILayout.Space();
            GUIStyle style = new GUIStyle();
            style.alignment = TextAnchor.UpperLeft;
            style.clipping = TextClipping.Clip;
            style.richText = true;
            GUILayout.Label(GetPreviewInfo(), style);
        }



        internal string GetPreviewInfo()
        {
            string tempPreviewInfo = "";
            //Copyright
            if (m_Date.m_TabData.m_UserCopyright)
            {
                tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, "#region Copyright");
                tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, "/* ----------------------------------------------------------- ");
                tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, " *   Copyright (c) {0} All rights reserved.");
                if (m_Date.m_TabData.m_CopyrightName != null)
                {
                    tempPreviewInfo = string.Format(tempPreviewInfo, m_Date.m_TabData.m_CopyrightName);
                }
                else
                {
                    tempPreviewInfo = string.Format(tempPreviewInfo, "***");
                }
                tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, " * ----------------------------------------------------------- ");
                //tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, " * Creater--------: #CREATORNAME#");
                //tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, " * CreateTime-----: #CREATETIME# ");
                tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, " * Creater--------: #DEVELOPERNAME#");
                tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, " * CreateTime-----: #CREATIONDATE# ");
                tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, " * Msg------------: ");
                tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, " * ---------------------------------------------------------*/ ");
                tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, "#endregion Copyright\n");
            }
            //using
            if (m_Date.m_TabData.m_UsingNamespace != null)
            {
                for (int i = 0; i < m_Date.m_TabData.m_UsingNamespace.Count; i++)
                {
                    tempPreviewInfo = string.Format("{0}\nusing {1};", tempPreviewInfo, m_Date.m_TabData.m_UsingNamespace[i]);
                }
                tempPreviewInfo = string.Format("{0}\n\n", tempPreviewInfo);
            }
            string templinehand = "";

            //namespace
            if (m_Date.m_TabData.m_Namespace)
            {
                //tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, "namespace #NAMESPACE#  \n{");
                tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, "namespace #ROOTNAMESPACE#  \n{");
                templinehand = string.Format("{0}{1}", templinehand, "\u3000\u3000");
            }
            tempPreviewInfo = string.Format("{0}\n{1}{2}", tempPreviewInfo, templinehand, "public class #SCRIPTNAME# : MonoBehaviour");
            tempPreviewInfo = string.Format("{0}\n{1}{2}", tempPreviewInfo, templinehand, "{");

            //module
            if (m_Date.m_TabData.m_ModuleInfo != null)
            {
                var templinehandtwo = string.Format("{0}{1}", templinehand, "\u3000\u3000");
                for (int i = 0; i < m_Date.m_TabData.m_ModuleInfo.Count; i++)
                {
                    Tools_FileTemplate.ModuleInfo tempmodule = m_Date.m_TabData.m_ModuleInfo[i];

                    if (string.IsNullOrEmpty(tempmodule.Name))
                    {
                        continue;
                    }
                    tempPreviewInfo = string.Format("{0}\n{1}#region {2}", tempPreviewInfo, templinehandtwo, tempmodule.Name);
                    if (tempmodule.m_Methods != null)
                    {
                        for (int j = 0; j < tempmodule.m_Methods.Count; j++)
                        {
                            if (string.IsNullOrEmpty(tempmodule.m_Methods[j]))
                            {
                                continue;
                            }
                            tempPreviewInfo = string.Format("{0}\n{1}private void {2}", tempPreviewInfo, templinehandtwo, tempmodule.m_Methods[j]);
                            tempPreviewInfo = string.Format("{0}\n{1}{2}", tempPreviewInfo, templinehandtwo, "{");
                            tempPreviewInfo = string.Format("{0}\n{1}{2}", tempPreviewInfo, templinehandtwo, "}");
                        }
                    }
                    tempPreviewInfo = string.Format("{0}\n{1}#endregion\n", tempPreviewInfo, templinehandtwo);
                }
            }

            tempPreviewInfo = string.Format("{0}\n{1}{2}", tempPreviewInfo, templinehand, "}");
            if (m_Date.m_TabData.m_Namespace)
            {
                tempPreviewInfo = string.Format("{0}\n{1}", tempPreviewInfo, "}");
            }

            tempPreviewInfo = string.Format("{0}\n\n", tempPreviewInfo);
            return tempPreviewInfo;
        }

        internal void SaveFileInfo()
        {
            try
            {
                string content = GetPreviewInfo();
                var path = EditorApplication.applicationContentsPath + "/Resources/ScriptTemplates/81-C# Script-NewBehaviourScript.cs.txt";
                if (File.Exists(path))
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(content);
                    FileStream file = File.Create(path);
                    file.Write(bytes, 0, bytes.Length);
                    file.Close();
                }
            }
            catch
            {
                EditorUtility.DisplayDialog("", "Replace File Fail", "Close");
            }
            finally
            {
                EditorUtility.DisplayDialog("", "Replace File Success", "Close");
            }
        }
    }
}