using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Framework.UI
{
    [AddComponentMenu("Helper/UI/ImageBG")]
    [RequireComponent(typeof(Image))]
    public class UIImageBG : MonoBehaviour
    {
        public Text m_Text;
        public Padding _Padding;
        private Image m_BG;
        private RectTransform m_Rect;
        private void Awake()
        {
            m_BG = this.GetComponent<Image>();
            m_Rect = this.GetComponent<RectTransform>();
        }
        void OnEnable()
        {
            if (m_Text != null)
            {
                m_Text.RegisterDirtyVerticesCallback(ValueUpdata);
            }
        }
        private void Update()
        {
            UpDateEnable();
        }
        void OnDisable()
        {
            if (m_Text != null)
            {
                m_Text.UnregisterDirtyVerticesCallback(ValueUpdata);
            }
            UpDatePos();
        }
#if UNITY_EDITOR
        private void OnValidate()
        {
            ValueUpdata();
        }
#endif
        private void ValueUpdata()
        {
            UpDateSize();
            UpDatePos();
        }


        /// <summary>
        /// 更新激活状态
        /// </summary>
        private void UpDateEnable()
        {
            if (m_Text != null)
            {
                if (m_Text.enabled && m_Text.gameObject.activeSelf)
                {
                    if (!m_BG.enabled)
                    {
                        m_BG.enabled = true;
                    }
                }
                else if (m_BG.enabled)
                {
                    m_BG.enabled = false;
                }
            }
            else if (m_BG.enabled)
            {
                m_BG.enabled = false;
            }
        }
        /// <summary>
        /// 更新大小
        /// </summary>
        private void UpDateSize()
        {
            float wdith = _Padding.left + _Padding.right;
            float height = _Padding.top + _Padding.bottom;
            if (m_Text.horizontalOverflow == HorizontalWrapMode.Wrap)
            {
                if (m_Text.preferredWidth <= m_Text.rectTransform.rect.width)
                {
                    wdith += m_Text.preferredWidth;
                }
                else
                {
                    wdith += m_Text.rectTransform.rect.width;
                }
            }
            else
            {
                wdith += m_Text.preferredWidth;
            }
            if (m_Text.verticalOverflow == VerticalWrapMode.Truncate)
            {
                if (m_Text.preferredHeight <= m_Text.rectTransform.rect.height)
                {
                    height += m_Text.preferredHeight;
                }
                else
                {
                    height += m_Text.rectTransform.rect.height;
                }
            }
            else
            {
                height += m_Text.preferredHeight;
            }
            if (m_Rect == null)
            {
                m_Rect = this.GetComponent<RectTransform>();
            }
            m_Rect.sizeDelta = new Vector2(wdith, height);
        }
        /// <summary>
        /// 更新位置
        /// </summary>
        private void UpDatePos()
        {
            float x = _Padding.right - _Padding.left;
            float y = _Padding.top - _Padding.bottom;
            this.transform.localPosition = m_Text.transform.localPosition + new Vector3(x/2, y/2);
        }



        [System.Serializable]
        public struct Padding
        {
            public float left;
            public float right;
            public float top;
            public float bottom;
        }
    }
}