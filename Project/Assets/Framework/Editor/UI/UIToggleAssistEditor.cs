
#region 版权信息
/*
 * -----------------------------------------------------------
 *  Copyright (c) KeJun All rights reserved.
 * -----------------------------------------------------------
 *		描述: 
 *      创建者：#DEVELOPERNAME#
 *      创建时间: #CREATIONDATE#
 *  
 */
#endregion


using UnityEngine;
using UnityEditor;
using System.Collections;
using Framework.UI;
using UnityEngine.UI;

namespace Framework.Editor.UI
{
    [CustomEditor(typeof(UIToggleAssist))]
    public class UIToggleAssistEditor : UnityEditor.Editor
    {
        private UIToggleAssist m_Assist;
        private SerializedProperty 
            ValueChanged,
            ValueChangedGame
            ;
        private void OnEnable()
        {
            ValueChanged = serializedObject.FindProperty("onValueChanged");
            ValueChangedGame = serializedObject.FindProperty("onValueChangedGame");
        }
        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();
            m_Assist = (UIToggleAssist)(target);
            m_Assist.interactable = EditorGUILayout.Toggle("Interactable", m_Assist.interactable);
            m_Assist.transition = (Selectable.Transition)EditorGUILayout.EnumPopup("Transition", m_Assist.transition);
            if (m_Assist.transition == Selectable.Transition.ColorTint)
            {
                m_Assist.targetGraphic = (Image)EditorGUILayout.ObjectField("\u3000Target Graphic", m_Assist.targetGraphic, typeof(Image), false);
                ColorBlock temp_colors = m_Assist.colors;
                temp_colors.normalColor = EditorGUILayout.ColorField("\u3000Normal Color", m_Assist.colors.normalColor);
                temp_colors.highlightedColor = EditorGUILayout.ColorField("\u3000Highlighted Color", m_Assist.colors.highlightedColor);
                temp_colors.pressedColor = EditorGUILayout.ColorField("\u3000Pressed Color", m_Assist.colors.pressedColor);
                temp_colors.disabledColor = EditorGUILayout.ColorField("\u3000Disabled Color", m_Assist.colors.disabledColor);
                temp_colors.colorMultiplier = EditorGUILayout.Slider("\u3000Color Multiplier", m_Assist.colors.colorMultiplier, 1, 5);
                temp_colors.fadeDuration = EditorGUILayout.FloatField("\u3000Fade Duration", m_Assist.colors.fadeDuration);
                m_Assist.colors = temp_colors;
            }
            else if (m_Assist.transition == Selectable.Transition.SpriteSwap)
            {
                m_Assist.targetGraphic = (Image)EditorGUILayout.ObjectField("\u3000Target Graphic", m_Assist.targetGraphic, typeof(Image), false);
                SpriteState temp_sprite = m_Assist.spriteState;
                temp_sprite.highlightedSprite = (Sprite)EditorGUILayout.ObjectField("\u3000Highlighted Sprite", m_Assist.spriteState.highlightedSprite, typeof(Sprite), false);
                temp_sprite.pressedSprite = (Sprite)EditorGUILayout.ObjectField("\u3000Pressed Sprite", m_Assist.spriteState.pressedSprite, typeof(Sprite), false);
                temp_sprite.disabledSprite = (Sprite)EditorGUILayout.ObjectField("\u3000Disabled Sprite", m_Assist.spriteState.disabledSprite, typeof(Sprite), false);
                m_Assist.spriteState = temp_sprite;
            }
            else if (m_Assist.transition == Selectable.Transition.Animation)
            {
                AnimationTriggers temp_Animation = m_Assist.animationTriggers;
                temp_Animation.normalTrigger = EditorGUILayout.TextField("\u3000Normal Trigger", m_Assist.animationTriggers.normalTrigger);
                temp_Animation.highlightedTrigger = EditorGUILayout.TextField("\u3000Highlighted Trigger", m_Assist.animationTriggers.highlightedTrigger);
                temp_Animation.pressedTrigger = EditorGUILayout.TextField("\u3000Pressed Trigger", m_Assist.animationTriggers.pressedTrigger);
                temp_Animation.disabledTrigger = EditorGUILayout.TextField("\u3000Disabled Trigger", m_Assist.animationTriggers.disabledTrigger);
                m_Assist.animationTriggers = temp_Animation;
            }
            EditorGUILayout.Space();
            Navigation temp_Navigation = m_Assist.navigation;
            temp_Navigation.mode = (Navigation.Mode)EditorGUILayout.EnumPopup("Navigation", m_Assist.navigation.mode);
            EditorGUILayout.Space();
            m_Assist.isOn = EditorGUILayout.Toggle("Is On",m_Assist.isOn);
            m_Assist.toggleTransition = (Toggle.ToggleTransition)EditorGUILayout.EnumPopup("Toggle Transition", m_Assist.toggleTransition);
            m_Assist.graphic = (Graphic)EditorGUILayout.ObjectField("Graphic", m_Assist.graphic, typeof(Graphic), false);
            m_Assist.group = (ToggleGroup)EditorGUILayout.ObjectField("Group", m_Assist.group, typeof(ToggleGroup), false);
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(ValueChanged);
            if (ValueChangedGame != null)
                EditorGUILayout.PropertyField(ValueChangedGame);


            //刷新数据存储
            serializedObject.ApplyModifiedProperties();
        }
    }
}