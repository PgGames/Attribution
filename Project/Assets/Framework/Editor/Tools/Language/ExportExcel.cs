using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;

namespace Framework.Editor.Tools.Language
{
    public class ExportExcel : WindowBase
    {
        internal LanguageDate m_date = new LanguageDate();
        private string filepath = "Excels/Exports";

        internal override void OnEnable(EditorWindow editor)
        {
            m_date = Tools_Public.ReadDate<LanguageDate>(filepath);
            if (m_date == null)
            {
                m_date = new LanguageDate();
                m_date.languagepath = new List<string>();
                m_date.excelpath = "";
            }
            if (m_date.languagepath == null)
            {
                m_date.languagepath = new List<string>();
            }
            if (m_date.excelpath == null)
            {
                m_date.excelpath = "";
            }
        }


        internal override void OnDisable()
        {
            Tools_Public.SaveDate(filepath, m_date);
        }

        internal override void OnGUI()
        {
            EditorGUILayout.BeginVertical();
            //Excel Â·¾¶
            using (new EditorGUI.DisabledScope())
            {
                m_date.excelpath = EditorGUILayout.TextField("Excel Path", m_date.excelpath);
                EditorGUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("OpenFile", GUILayout.MaxWidth(Tools_Public.Tools_MinButtonWidth)))
                {
                    var newPath = EditorUtility.OpenFolderPanel("OpenFile", Application.dataPath, "");
                    if (!string.IsNullOrEmpty(newPath))
                    {
                        newPath = newPath.Replace("\\", "/");
                        m_date.excelpath = newPath;
                    }
                }
                EditorGUILayout.EndHorizontal();
            }

            //µ¼³ö import
            using (new EditorGUI.DisabledScope())
            {
                if (Tools_Public.CenterButton("Export Excel", GUILayout.Width(Tools_Public.Tools_MaxButtonWidth)))
                {

                }
            }

            EditorGUILayout.EndVertical();
        }



        [System.Serializable]
        internal class LanguageDate : BaseDate
        {
            internal string excelpath;
            internal List<string> languagepath;
        }
    }
}