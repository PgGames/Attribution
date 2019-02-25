using UnityEngine;
using System.Collections;
using System;

namespace Framework
{
    public sealed class Debuger : ILogHandler//: ILogger
    {
        public Debuger()
        {
        }

        private static ILogger unityloger;
        //private bool Enabled;
        //private LogType FilterLogType;


        private static Debuger _Debug;
        private static Debuger GetDebug {
            get {
                if (_Debug == null)
                    _Debug = new Debuger();
                return _Debug;
            }
        }


        public static void Log(string str)
        {
            GetDebug.LogFormat(LogType.Log,null, str);
        }

        public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
        {
            string tempstr = "";
            switch (logType)
            {
                case LogType.Error:
                    tempstr = "<color=#FF0000FF>{0}</color>";
                    break;
                case LogType.Assert:
                    tempstr = "{0}";
                    break;
                case LogType.Warning:
                    tempstr = "<color=#FFFF00FF>{0}</color>";
                    break;
                case LogType.Log:
                    tempstr = "<color=#FFFFFFFF>{0}</color>";
                    break;
                case LogType.Exception:
                    tempstr = "{0}";
                    break;
                default:
                    break;
            }
            Console.WriteLine(string.Format(tempstr, format));

        }

        public void LogException(Exception exception, UnityEngine.Object context)
        {
        }
    }
}