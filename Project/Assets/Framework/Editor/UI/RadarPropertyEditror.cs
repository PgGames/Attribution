using UnityEngine;
using System.Collections;
using UnityEditor;
using Framework.UI.Radar;
using System.Collections.Generic;

namespace Framework.Editor.UI
{
    [CustomEditor(typeof(RadarProperty))]
    public class RadarPropertyEditror : UnityEditor.Editor
    {
        private RadarProperty m_Class;


        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();
            m_Class = (RadarProperty)target;
            
            int index = EditorGUILayout.IntField("Sum", (int)m_Class.m_Sum);
            if (index <= 3)
            {
                m_Class.m_Sum = 3;
            }
            else
            {
                m_Class.m_Sum = (uint)index;
            }
            RectTransform rect = m_Class.GetComponent<RectTransform>();
            if (rect == null)
            {
                m_Class.m_Sizes = EditorGUILayout.Vector2Field("Size", m_Class.m_Sizes);
            }
            else
            {
                m_Class.m_Sizes = new Vector2(rect.sizeDelta.x, rect.sizeDelta.y);
                m_Class.m_Sizes /= 2.0f;
            }
            //背景信息
            m_Class.m_IsBG = EditorGUILayout.Toggle("BG", m_Class.m_IsBG);
            if (m_Class.m_IsBG)
            {
                BGInfo();
            }
            //属性信息
            m_Class.m_IsProperty = EditorGUILayout.Toggle("Property", m_Class.m_IsProperty);
            if (m_Class.m_IsProperty)
            {
                PropertyGUI();
            }
            //画线信息
            m_Class.m_IsDrawLine = EditorGUILayout.Toggle("Draw Line", m_Class.m_IsDrawLine);
            if (m_Class.m_IsDrawLine)
            {
                LineGUI();
            }

            //射线检测
            m_Class.raycastTarget = EditorGUILayout.Toggle("Raycast Target", m_Class.raycastTarget);

            m_Class.OnRebuildRequested();

            serializedObject.ApplyModifiedProperties();
        }

        private void BGInfo()
        {
            m_Class.color = EditorGUILayout.ColorField("BG Color", m_Class.color);
            m_Class.material = (Material)EditorGUILayout.ObjectField("Material", m_Class.material, typeof(Material), false);
        }

        private void PropertyGUI()
        {
            m_Class.m_PropertyColor = EditorGUILayout.ColorField("Property Color", m_Class.m_PropertyColor);

            //最大值
            if (m_Class.m_MaxValue.Count < m_Class.m_Sum)
            {
                int tempindex = (int)m_Class.m_Sum - m_Class.m_MaxValue.Count;
                uint value = 0;
                if (m_Class.m_MaxValue.Count != 0)
                {
                    value = m_Class.m_MaxValue[m_Class.m_MaxValue.Count - 1];
                }
                for (int i = 0; i < tempindex; i++)
                {
                    m_Class.m_MaxValue.Add(value);
                }
            }
            else if (m_Class.m_MaxValue.Count > m_Class.m_Sum)
            {
                int tempindex = m_Class.m_MaxValue.Count - (int)m_Class.m_Sum;
                m_Class.m_MaxValue.RemoveRange((int)m_Class.m_Sum, tempindex);
            }
            //当前值
            if (m_Class.m_CurrValue.Count < m_Class.m_Sum)
            {
                int tempindex = (int)m_Class.m_Sum - m_Class.m_CurrValue.Count;
                float value = 0;
                if (m_Class.m_CurrValue.Count != 0)
                {
                    value = m_Class.m_CurrValue[m_Class.m_CurrValue.Count - 1];
                }
                for (int i = 0; i < tempindex; i++)
                {
                    m_Class.m_CurrValue.Add(value);
                }
            }
            else if (m_Class.m_CurrValue.Count > m_Class.m_Sum)
            {
                int tempindex = m_Class.m_CurrValue.Count - (int)m_Class.m_Sum;
                m_Class.m_CurrValue.RemoveRange((int)m_Class.m_Sum, tempindex);
            }

            for (int i = 0; i < m_Class.m_MaxValue.Count; i++)
            {
                Vector2 temppos = new Vector2((int)m_Class.m_MaxValue[i], m_Class.m_CurrValue[i]);
                Vector2 tempvector = EditorGUILayout.Vector2Field("Property " + i.ToString(), temppos);
                if (tempvector.x <= 0)
                {
                    tempvector.x = 0;
                }
                int tempint = (int)(tempvector.x - tempvector.x % 1);
                if (tempvector.y <= 0)
                {
                    tempvector.y = 0;
                }
                else if (tempvector.y >= tempint)
                {
                    tempvector.y = tempint;
                }
                uint tempMaxValue = (uint)tempvector.x;
                float tempcurValue = tempvector.y;

                m_Class.m_MaxValue[i] = tempMaxValue;
                m_Class.m_CurrValue[i] = tempcurValue;
            }
        }
        private void LineGUI()
        {
            m_Class.m_LineColor = EditorGUILayout.ColorField("Line Color", m_Class.m_LineColor);
            m_Class.m_LineSize = EditorGUILayout.FloatField("Line Size", m_Class.m_LineSize);
            if (m_Class.m_LineSize <= 0)
            {
                m_Class.m_LineSize = 0;
            }
            m_Class.m_LineSum = (uint)EditorGUILayout.IntField("Line Sum", (int)m_Class.m_LineSum);
            if (m_Class.m_LineSum <= 1)
            {
                m_Class.m_LineSum = 1;
            }
        }
    }

}