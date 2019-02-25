using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Excel;
using System.Data;

namespace Framework.Editor.Tools.Language
{
    public class ImportExcel : WindowBase
    {
        internal LanguageDate m_date = new LanguageDate();
        private string filepath = "Excels/Imports";

        internal override void OnEnable(EditorWindow editor)
        {
            m_date = Tools_Public.ReadDate<LanguageDate>(filepath);
            if (m_date == null)
            {
                m_date = new LanguageDate();
                m_date.languagepath = "";
                m_date.excelpath = "";
            }
            if (m_date.languagepath == null)
            {
                m_date.languagepath = "";
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
            //Excel 路径
            using (new EditorGUI.DisabledScope())
            {
                m_date.excelpath = EditorGUILayout.TextField("Excel Path", m_date.excelpath);
                EditorGUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("ReadFile", GUILayout.MaxWidth(Tools_Public.Tools_MinButtonWidth)))
                {
                }
                if (GUILayout.Button("OpenFile", GUILayout.MaxWidth(Tools_Public.Tools_MinButtonWidth)))
                {
                    var newPath = EditorUtility.OpenFilePanel("OpenFile", Application.dataPath, "xlsx,xls");
                    if (!string.IsNullOrEmpty(newPath))
                    {
                        newPath = newPath.Replace("\\", "/");
                        m_date.excelpath = newPath;
                    }
                }
                EditorGUILayout.EndHorizontal();
            }
            //Language 路径
            using (new EditorGUI.DisabledScope())
            {
                m_date.languagepath = EditorGUILayout.TextField("Language Path", m_date.languagepath);
                EditorGUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("OpenFile", GUILayout.MaxWidth(Tools_Public.Tools_MinButtonWidth)))
                {
                    var newPath = EditorUtility.OpenFolderPanel("OpenFile", Application.dataPath + "/" + m_date.languagepath, "");
                    if (!string.IsNullOrEmpty(newPath))
                    {
                        newPath = newPath.Replace("\\", "/");
                        var temppath = Application.dataPath.Replace("\\", "/");
                        newPath = newPath.Replace(temppath + "/", "");
                        m_date.languagepath = newPath;
                    }
                }
                EditorGUILayout.EndHorizontal();
            }
            //导入 import
            using (new EditorGUI.DisabledScope())
            {

                m_date.m_SaveType = (LanguageType)EditorGUILayout.EnumPopup("Save File Type",m_date.m_SaveType);

                if (Tools_Public.CenterButton("Import Excel", GUILayout.Width(Tools_Public.Tools_MaxButtonWidth)))
                {
                    ImportExcelFile();
                    AssetDatabase.Refresh();
                }
            }
            EditorGUILayout.EndVertical();
        }

        /// <summary>
        /// 导入Excel文件
        /// </summary>
        void ImportExcelFile()
        {
            //读取Excel文档
            FileStream stream = File.Open(m_date.excelpath, FileMode.Open);
            IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet dataSet = excelDataReader.AsDataSet();
            excelDataReader.Close();
            //解析Excel文档
            AnalysisExcel(dataSet);
        }
        /// <summary>
        /// 解析Excel
        /// </summary>
        /// <param name="data"></param>
        void AnalysisExcel(DataSet data)
        {
            //行数
            int column = data.Tables[0].Columns.Count;
            //列数
            int row = data.Tables[0].Rows.Count;

            if (column <= 2 || row < 2)
            {
                EditorUtility.DisplayDialog("", "Import Excel Error", "OK");
                return;
            }

            List<Dictionary<string, string>> TempLanguageInfo = new List<Dictionary<string, string>>();
            for (int i = 0; i < row-1; i++)
            {
                Dictionary<string, string> tempDic = new Dictionary<string, string>();
                TempLanguageInfo.Add(tempDic);
            }
            //行数信息
            for (int i = 0; i < column; i++)
            {
                string key = "";
                //列数信息
                for (int j = 0; j < row; j++)
                {
                    if (j == 0)
                    {
                        key = data.Tables[0].Rows[i][j].ToString();
                    }
                    else
                    {
                        int index = j - 1;
                        string value = data.Tables[0].Rows[i][j].ToString();
                        Dictionary<string, string> tempDic = TempLanguageInfo[index];
                        if (tempDic.ContainsKey(key))
                        {
                            tempDic[key] = value;
                        }
                        else
                        {
                            tempDic.Add(key, value);
                        }
                    }
                }
            }
            for (int i = 0; i < TempLanguageInfo.Count; i++)
            {
                SaveDate(TempLanguageInfo[i]);
            }
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="keyValues"></param>
        private void SaveDate(Dictionary<string, string> keyValues)
        {
            string filename = null;
            List<string> texts = new List<string>();

            foreach (var item in keyValues)
            {
                string str = "";
                if (filename == null)
                {
                    switch (m_date.m_SaveType)
                    {
                        case LanguageType.Txt:
                            filename = string.Format("{0}/{1}/{2}.txt", Application.dataPath, m_date.languagepath, item.Value);
                            str = "";
                            break;
                        case LanguageType.Json:
                            filename = string.Format("{0}/{1}/{2}.json", Application.dataPath, m_date.languagepath, item.Value);
                            str = "[";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (m_date.m_SaveType)
                    {
                        case LanguageType.Txt:
                            str = string.Format("Text {0} = [{1}]", item.Key, item.Value);
                            break;
                        case LanguageType.Json:
                            str = string.Format("{0} \"Key\":\"{1}\",\"Value\":\"{2}\"{3}", "{", item.Key, item.Value, "}");
                            break;
                        default:
                            break;
                    }
                }
                texts.Add(str);
            }
            if (m_date.m_SaveType == LanguageType.Json)
            {
                texts.Add("]");
            }
            if (!Directory.Exists(Path.GetDirectoryName(filename)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filename));
            }
            File.WriteAllLines(filename, texts.ToArray());
        }

        //internal class 


        [System.Serializable]
        internal class LanguageDate :BaseDate
        {
            internal string excelpath;
            internal LanguageType m_SaveType;
            internal string languagepath;
        }
        [System.Serializable]
        internal enum LanguageType
        {
            Txt,
            Json,
        }
    }
}