using UnityEngine;
using System.IO;
using UnityEditor;

namespace Framework.Editor.Tools
{
    [InitializeOnLoad]
    public class Tools_NewScripts : UnityEditor.AssetModificationProcessor
    {
        static Tools_NewScripts()
        {
            //EditorApplication.update += UpdateAllScripts;
            
        }
        
        //private static void UpdateAllScripts()
        //{
        //    Debug.Log("编译开始时间:" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        //    if (!EditorApplication.isUpdating)
        //    {
        //        EditorApplication.update -= UpdateAllScripts;
        //    }
        //}




        [UnityEditor.Callbacks.DidReloadScripts]
        private static void AllScriptsReloaded()
        {
            Debug.Log("编译完成时间:"+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        private static void OnWillCreateAsset(string path)
        {

            var temppath = path.Replace(".meta", "");
            //获取文件后缀
            var tempfileSuffix = Path.GetExtension(temppath);
            if (tempfileSuffix == ".cs")
            {
                string content = File.ReadAllText(temppath);
                //替换文本中的内容
                //更改为自定义的规则
                //创建人
                var temp_CreatorName = SettingCreatorName();
                content = content.Replace("#CREATORNAME#", temp_CreatorName);
                content = content.Replace("#DEVELOPERNAME#", temp_CreatorName);
                //创建时间
                var temp_CreatTime = SettingCreateTime();
                content = content.Replace("#CREATETIME#", temp_CreatTime);
                content = content.Replace("#CREATIONDATE#", temp_CreatTime);
                //命名空间
                var temp_namespace = SettingNameSpace(temppath);
                content = content.Replace("#NAMESPACE#", temp_namespace);
                content = content.Replace("#ROOTNAMESPACE#", temp_namespace);

                File.WriteAllText(temppath, content);
                //刷新资源
                AssetDatabase.Refresh();
            }
        }
        /// <summary>
        /// 设置创建者名称
        /// </summary>
        /// <returns></returns>
        private static string SettingCreatorName()
        {
            return "";
        }
        /// <summary>
        /// 设置创建时间
        /// </summary>
        /// <returns></returns>
        private static string SettingCreateTime()
        {
            var tempCreateTime = "";
            tempCreateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return tempCreateTime;
        }
        /// <summary>
        /// 设置命名空间
        /// </summary>
        /// <param name="varpath"></param>
        /// <returns></returns>
        private static string SettingNameSpace(string varpath)
        {
            var temp_namespace = "";
            var tmep_FileName = Path.GetFileName(varpath);
            var tmep_DirectoryName = Path.GetDirectoryName(varpath);
            temp_namespace = tmep_DirectoryName.Replace("/", ".");
            temp_namespace = temp_namespace.Replace("Scripts", "");
            temp_namespace = temp_namespace.Replace("Assets", "");
            temp_namespace = temp_namespace.Replace("Resources", "");
            temp_namespace = temp_namespace.Replace("..", ".");

            temp_namespace = temp_namespace.Trim('.');
            if (string.IsNullOrEmpty(temp_namespace))
            {
                temp_namespace = tmep_FileName + "namespace";
            }
            temp_namespace = temp_namespace.Replace(" ","");
            return temp_namespace;
        }
        
    }
}