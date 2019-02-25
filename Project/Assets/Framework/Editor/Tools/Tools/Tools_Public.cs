using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Framework.Editor.Tools
{
    public sealed class Tools_Public
    {
        private Tools_Public()
        { }


        public const float Tools_BoxWidth = 150f;
        public const float Tools_FieldWidth = 400f;
        public const float Tools_Space = 18f;
        public const float Tools_barPadding = 15f;

        public const float Tools_MinButtonWidth = 75f;
        public const float Tools_ButtonWidth = 100f;
        public const float Tools_MaxButtonWidth = 150f;
        public const float Tools_Buttonspacing = 5f;

        /// <summary>
        /// 枚举按钮
        /// 
        ///     15px的边距
        /// </summary>
        /// <typeparam name="T">枚举类型</typeparam>
        /// <param name="varEnum">枚举值</param>
        /// <param name="width">总宽度</param>
        /// <param name="options">按钮属性</param>
        /// <returns></returns>
        public static bool EnumButton<T>(ref T varEnum, float width, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginHorizontal();
            string[] tringname = System.Enum.GetNames(varEnum.GetType());
            int count = tringname.Length;
            float bottonwidth = (width - Tools_barPadding * 2 - Tools_Buttonspacing * (count - 1)) / count;

            GUILayout.Space(Tools_barPadding);

            for (int i = 0; i < count; i++)
            {
                string tempName = tringname[i];
                if (GUILayout.Button(tempName, GUILayout.Width(bottonwidth)))
                {
                    object temp = (System.Enum.Parse(varEnum.GetType(), tempName));
                    varEnum = (T)temp;
                    return true;
                }
            }
            EditorGUILayout.EndHorizontal();
            return false;
        }

        /// <summary>
        /// 居中按钮
        /// </summary>
        /// <param name="text">按钮文字</param>
        /// <param name="options">按钮属性</param>
        /// <returns></returns>
        public static bool CenterButton(string text, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button(text, options))
            {
                return true;
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            return false;
        }

        public static bool RightButton(string text,params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button(text, options))
            {
                return true;
            }
            GUILayout.EndHorizontal();
            return false;
        }

        /// <summary>
        /// 居中文字
        /// </summary>
        /// <param name="text"></param>
        /// <param name="options">按钮属性</param>
        public static void CenterLabel(string text, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Label(text, options);
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
        }



        /// <summary>
        /// 读取数据
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="path">读取文件名</param>
        /// <returns></returns>
        public static T ReadDate<T>(string path) where T : BaseDate
        {
            T date = null;
            var dataPath = System.IO.Path.GetFullPath(".");
            dataPath = dataPath.Replace("\\", "/");
            dataPath += "/Library/Tools/" + path + ".dat";
            //读取数据
            if (File.Exists(dataPath))
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream file = File.Open(dataPath, FileMode.Open);
                    date = bf.Deserialize(file) as T;
                    file.Close();
                }
                catch
                {
                    File.Delete(dataPath);
                    Debug.LogError("Read dat error on path :"+dataPath);
                }
            }
            return date;
        }

        /// <summary>
        /// 存储数据
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="path">存储文件名</param>
        /// <param name="date">数据信息</param>
        public static void SaveDate<T>(string path, T date) where T : BaseDate
        {
            var dataPath = System.IO.Path.GetFullPath(".");
            dataPath = dataPath.Replace("\\", "/");
            dataPath += "/Library/Tools/" + path + ".dat";
            //判断文件路径是否存在
                if (!File.Exists(dataPath))
                {
                    if (!Directory.Exists(Path.GetDirectoryName(dataPath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(dataPath));
                    }
                }
            try
            {
                //存储数据

                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create(dataPath);

                bf.Serialize(file, date);
                file.Close();
            }
            catch
            {
                Debug.LogError("Save dat error on path :" + dataPath);
            }
        }
    }
    [System.Serializable]
    public class BaseDate
    {
    }
}