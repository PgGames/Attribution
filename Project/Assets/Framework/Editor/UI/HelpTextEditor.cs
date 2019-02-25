
#region 版权信息
/*
 * -----------------------------------------------------------
 *  Copyright (c) All rights reserved.
 * -----------------------------------------------------------
 *		描述: 
 *      创建者：#DEVELOPERNAME#
 *      创建时间: #CREATIONDATE#
 *  
 */
#endregion


using UnityEngine;
using System.Collections;
using UnityEditor;
using Framework.UI;

namespace Framework.Editor.UI
{
    [CustomEditor(typeof(HelpText))]
    [CanEditMultipleObjects]
    public class HelpTextEditor : UnityEditor.Editor
    {
        //private SerializedObject m_Obj;
        private HelpText m_Class;
        private void Awake()
        {
            //m_Obj = new SerializedObject(target);
            
        }
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            m_Class = (HelpText)target;
            if (m_Class.m_Type == HelpText.Type.Money)
            {
                m_Class.Isfloat = EditorGUILayout.Toggle("IsFloat", m_Class.Isfloat);
            }
            else if (m_Class.m_Type == HelpText.Type.Text)
            {
                m_Class.Text_indent = EditorGUILayout.DelayedIntField("Text-indent", m_Class.Text_indent);
                m_Class.IsSpace = EditorGUILayout.Toggle("Space", m_Class.IsSpace);
            }
            else if (m_Class.m_Type == HelpText.Type.Password)
            {
                m_Class.PassLenght = EditorGUILayout.DelayedIntField("Lenght", m_Class.PassLenght);
            }
            else if (m_Class.m_Type == HelpText.Type.Name)
            {
                m_Class.IsSpace = EditorGUILayout.Toggle("Space", m_Class.IsSpace);
            }
            //Undo.RecordObject(target, "修改");
            //m_Obj.Update();
            //EditorGUI.BeginChangeCheck();

            //if (EditorGUI.EndChangeCheck())
            //    serializedObject.ApplyModifiedProperties();
        }
    }
}