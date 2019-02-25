using Framework.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Framework.Editor.UI
{
    [CustomEditor(typeof(RollingBulletin))]
    public class RollingBulletinEditor : UnityEditor.Editor
    {
        private SerializedObject obj;
        private RollingBulletin m_Roll;

        private void Awake()
        {
            m_Roll = (RollingBulletin)target;

            if (m_Roll.m_Text == null)
            {
                GameObject Go = new GameObject("Text");
                Go.transform.parent = m_Roll.transform;
                m_Roll.m_Text = Go.AddComponent<Text>();
            }
            m_Roll.m_Text.alignment = TextAnchor.MiddleCenter;

            
        }
        private void OnEnable()
        {
            
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
        }

    }

}