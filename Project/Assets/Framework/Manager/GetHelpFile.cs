using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;


namespace Framework
{
    public class HelpGetFile
    {
        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="Title">标题</param>
        /// <param name="path">默认路径</param>
        /// <param name="filter">文件类型</param>
        /// <returns></returns>
        public static string OpenFileGetPath(string Title, string path, string filter)
        {
            if (string.IsNullOrEmpty(path))
                throw new Exception("path is not null(HelpGetFile.cs)");
            OpenFileName openFile = new OpenFileName();
            openFile.structSize = Marshal.SizeOf(openFile);
            if (string.IsNullOrEmpty(filter))
                filter = "All Files\0*.*\0\0";
            openFile.filter = filter;

            openFile.file = new string(new char[256]);

            openFile.maxFile = openFile.file.Length;
            openFile.fileTitle = new string(new char[256]);
            openFile.maxFileTitle = openFile.fileTitle.Length;
            //string path = Application.streamingAssetsPath;
            path = path.Replace('/', '\\');
            //默认路径  
            openFile.initialDir = path;
            //窗口标题
            if (string.IsNullOrEmpty(Title))
                Title = "Open Project";
            openFile.title = Title;

            openFile.defExt = "JPG";//显示文件的类型  
            //注意 一下项目不一定要全选 但是0x00000008项不要缺少  
            openFile.flags = 0x00080000 | 0x00001000 | 0x00000800 | 0x00000200 | 0x00000008;//OFN_EXPLORER|OFN_FILEMUSTEXIST|OFN_PATHMUSTEXIST| OFN_ALLOWMULTISELECT|OFN_NOCHANGEDIR  

            if (WindowDll.GetOpenFileName(openFile))
            {
                return openFile.file;
            }
            return null;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class OpenFileName
        {
            public int structSize = 0;
            public IntPtr dlgOwner = IntPtr.Zero;
            public IntPtr instance = IntPtr.Zero;
            public string filter = null;
            public string customFilter = null;
            public int maxCustFilter = 0;
            public int filterIndex = 0;
            public string file = null;
            public int maxFile = 0;
            public string fileTitle = null;
            public int maxFileTitle = 0;
            public string initialDir = null;
            public string title = null;
            public int flags = 0;
            public short fileOffset = 0;
            public short fileExtension = 0;
            public string defExt = null;
            public IntPtr custData = IntPtr.Zero;
            public IntPtr hook = IntPtr.Zero;
            public string templateName = null;
            public IntPtr reservedPtr = IntPtr.Zero;
            public int reservedInt = 0;
            public int flagsEx = 0;
        }
        private class WindowDll
        {
            [DllImport("Comdlg32.dll", SetLastError = true, ThrowOnUnmappableChar = true, CharSet = CharSet.Auto)]
            public static extern bool GetOpenFileName([In, Out] OpenFileName ofn);
            public static bool GetOpenFileName1([In, Out] OpenFileName ofn)
            {
                return GetOpenFileName(ofn);
            }
        }
    }
}
