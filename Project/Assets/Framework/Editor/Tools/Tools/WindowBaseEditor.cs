
using UnityEditor;

namespace Framework.Editor.Tools
{
    public class WindowBaseEditor<T> : EditorWindow  where T : EditorWindow
    {
        protected static T s_instance = null;
        internal static T instance
        {
            get
            {
                if (s_instance == null)
                    s_instance = GetWindow<T>();
                return s_instance;
            }
        }
    }
}