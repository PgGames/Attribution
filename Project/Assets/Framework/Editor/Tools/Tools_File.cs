
using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;

namespace Framework.Editor
{
    public class Tools_File : MonoBehaviour
    {

        public static string GetFileDir(string varTitle,string varpath)
        {
            OpenDialogFile openFile = new OpenDialogFile();
            openFile.structSize = Marshal.SizeOf(openFile);
            //窗口标题
            if (string.IsNullOrEmpty(varTitle))
                varTitle = "Open Project";
            openFile.title = varTitle;
            varpath = varpath.Replace('/', '\\');
            //默认路径  
            openFile.initialDir = varpath;
            openFile.file = new string(new char[256]);

            openFile.maxFile = openFile.file.Length;
            openFile.fileTitle = new string(new char[256]);
            openFile.maxFileTitle = openFile.fileTitle.Length;
            //OpenDialogDir ofn2 = new OpenDialogDir();
            //ofn2.pszDisplayName = new string(new char[2000]); ;     // 存放目录路径缓冲区    
            //if (string.IsNullOrEmpty(varTitle))
            //    ofn2.lpszTitle = "Open Project";// 标题    
            ////ofn2.ulFlags = BIF_NEWDIALOGSTYLE | BIF_EDITBOX; // 新的样式,带编辑框    
            //IntPtr pidlPtr = DllOpenFileDialog.SHBrowseForFolder(ofn2);

            //char[] charArray = new char[2000];
            //for (int i = 0; i < 2000; i++)
            //    charArray[i] = '\0';

            //DllOpenFileDialog.SHGetPathFromIDList(pidlPtr, charArray);
            //string fullDirPath = new String(charArray);


            //fullDirPath = fullDirPath.Substring(0, fullDirPath.IndexOf('\0'));
            //注意 一下项目不一定要全选 但是0x00000008项不要缺少  
            openFile.flags = 0x00080000 | 0x00001000 | 0x00000800 | 0x00000200 | 0x00000008;
            if (DllOpenFileDialog.GetOpenFileName(openFile))
            {
                return openFile.file;
            }
            return null;
        }










        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class OpenDialogFile
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
        //[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        //public class OpenDialogDir
        //{
        //    public IntPtr hwndOwner = IntPtr.Zero;
        //    public IntPtr pidlRoot = IntPtr.Zero;
        //    public string pszDisplayName = null;
        //    public string lpszTitle = null;
        //    public uint ulFlags = 0;
        //    public IntPtr lpfn = IntPtr.Zero;
        //    public IntPtr lParam = IntPtr.Zero;
        //    public int iImage = 0;
        //}

        public class DllOpenFileDialog
        {
            [DllImport("Comdlg32.dll", SetLastError = true, ThrowOnUnmappableChar = true, CharSet = CharSet.Auto)]
            public static extern bool GetOpenFileName([In, Out] OpenDialogFile ofn);

            [DllImport("Comdlg32.dll", SetLastError = true, ThrowOnUnmappableChar = true, CharSet = CharSet.Auto)]
            public static extern bool GetSaveFileName([In, Out] OpenDialogFile ofn);

            [DllImport("shell32.dll", SetLastError = true, ThrowOnUnmappableChar = true, CharSet = CharSet.Auto)]
            public static extern bool SHGetPathFromIDList([In] IntPtr pidl, [In, Out] char[] fileName);
            public static bool GetOpenFileName1([In, Out] OpenDialogFile ofn)
            {
                return GetOpenFileName(ofn);
            }
        }
    }
}