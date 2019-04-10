using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Framework.UI
{
    /// <summary>
    /// 文字背景图片
    ///     优点：可动态根据文本大小变幻图片大小
    ///     确定：由于实际大小与RectTransform的大小关系会出现一个字的大小偏差
    /// </summary>
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
            Debug.LogError("Flexible "+ m_Text.flexibleWidth +"<====>"+ m_Text.flexibleHeight);
            Debug.LogError("main " + m_Text.minWidth + "<====>" + m_Text.minHeight);
            Debug.LogError("preferred " + m_Text.preferredWidth + "<====>" + m_Text.preferredHeight);


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
            float y = _Padding.top - _Padding.bottom;
            float x = _Padding.right - _Padding.left;
            //实际大小
            Vector2 temp_TextSize = new Vector2(m_Text.preferredWidth, m_Text.preferredHeight);
            //限制大小
            Vector2 temp_RectSize = m_Text.rectTransform.rect.size;
            //横向位置计算
            if (m_Text.alignment == TextAnchor.UpperLeft || m_Text.alignment == TextAnchor.MiddleLeft || m_Text.alignment == TextAnchor.LowerLeft)
            {
                if (temp_TextSize.x <= temp_RectSize.x)
                {
                    x += temp_TextSize.x - temp_RectSize.x;
                }
                else
                {
                    if (m_Text.horizontalOverflow != HorizontalWrapMode.Wrap)
                    {
                        x += temp_TextSize.x - temp_RectSize.x;
                    }
                }
            }
            else if (m_Text.alignment == TextAnchor.LowerRight || m_Text.alignment == TextAnchor.MiddleRight || m_Text.alignment == TextAnchor.UpperRight)
            {
                if (temp_TextSize.x <= temp_RectSize.x)
                {
                    x -= temp_TextSize.x - temp_RectSize.x;
                }
                else
                {
                    if (m_Text.horizontalOverflow != HorizontalWrapMode.Wrap)
                    {
                        x -= temp_TextSize.x - temp_RectSize.x;
                    }
                }
            }
            //纵向位置计算
            if (m_Text.alignment == TextAnchor.LowerLeft || m_Text.alignment == TextAnchor.LowerCenter || m_Text.alignment == TextAnchor.LowerRight)
            {
                if (temp_TextSize.y <= temp_RectSize.y)
                {
                    y += temp_TextSize.y - temp_RectSize.y;
                }
                else
                {
                    if (m_Text.verticalOverflow != VerticalWrapMode.Truncate)
                    {
                        y += temp_TextSize.y - temp_RectSize.y;
                    }
                }
            }
            else if (m_Text.alignment == TextAnchor.UpperLeft || m_Text.alignment == TextAnchor.UpperCenter || m_Text.alignment == TextAnchor.UpperRight)
            {
                if (temp_TextSize.y <= temp_RectSize.y)
                {
                    y -= temp_TextSize.y - temp_RectSize.y;
                }
                else
                {
                    if (m_Text.verticalOverflow != VerticalWrapMode.Truncate)
                    {
                        y -= temp_TextSize.y - temp_RectSize.y;
                    }
                }
            }
            this.transform.localPosition = m_Text.transform.localPosition + new Vector3(x / 2, y / 2);
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