

using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Framework.Editor.Tools
{
    public class WindowBase
    {

        internal virtual void OnEnable(EditorWindow editor)
        {
        }
        internal virtual void OnDisable()
        {
        }
        internal virtual void OnGUI()
        {
        }
    }
}