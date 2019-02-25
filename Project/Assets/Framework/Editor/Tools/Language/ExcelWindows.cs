
using UnityEditor;
using UnityEngine;



namespace Framework.Editor.Tools.Language
{
    public class ExcelWindows : WindowBaseEditor<ExcelWindows>
    {

        [MenuItem("Tools/Language", priority = 11)]
        static void OpenWindows()
        {
            s_instance = null;
            instance.titleContent = new GUIContent("Language Excel");
            instance.Show();
        }


        internal ExcelWindows()
        {
            if (m_Export == null)
                m_Export = new ExportExcel();
            if (m_Import == null)
                m_Import = new ImportExcel();
        }

        private ImportExcel m_Import;
        private ExportExcel m_Export;

        private ExcelType m_type = ExcelType.ImportExcel;



        private void OnEnable()
        {

            if (m_Import != null)
            {
                m_Import.OnEnable(this);
            }
            if (m_Export != null)
            {
                m_Export.OnEnable(this);
            }
        }
        private void OnDisable()
        {
            if (m_Import != null)
            {
                m_Import.OnDisable();
            }
            if (m_Export != null)
            {
                m_Export.OnDisable();
            }
        }

        private Vector2 m_ScrollPosition;
        private void OnGUI()
        {
            m_ScrollPosition = EditorGUILayout.BeginScrollView(m_ScrollPosition);
            EditorGUILayout.BeginVertical();
            HandToggleUI();
            EditorGUILayout.Space();
            CententUI();


            EditorGUILayout.EndVertical();
            EditorGUILayout.EndScrollView();
        }


        private void HandToggleUI()
        {
            EditorGUILayout.Space();

            Tools_Public.EnumButton<ExcelType>(ref m_type, position.width);

            Tools_Public.CenterLabel("---->" + m_type.ToString() + "<----");

            EditorGUILayout.Space();
        }

        private void CententUI()
        {
            EditorGUILayout.BeginVertical();
            switch (m_type)
            {
                case ExcelType.ImportExcel:
                    if (m_Import != null)
                        m_Import.OnGUI();
                    break;
                case ExcelType.ExportExcel:
                    if (m_Export != null)
                        m_Export.OnGUI();
                    break;
                default:
                    break;
            }
            EditorGUILayout.EndVertical();
        }

        private enum ExcelType
        {
            ImportExcel,
            ExportExcel,
        }
    }
}