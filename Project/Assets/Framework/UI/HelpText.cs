
/*-----------------------------------
 *------------[功能脚本]-------------*  
 *----脚本功能：对UGUI组件中的Text组件进行优化
 *              脚本仅支持文字内容的中途变化
 *        [Password]---类型对输入的文字进行密码掩饰
 *        [Text]-------类型显示原有文字可进行缩进等处理
 *        [Name]-------类型根据文本框的长度进行操作超出用“…”进行掩饰(文字过多对性能消耗大)
 *        [Money]------类型根据数值大小显示万、亿
 *-----------------------------------*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace Framework.UI
{
    /// <summary>
    /// 
    /// </summary>
    [AddComponentMenu("Manager/UI/HelpText")]
    [RequireComponent(typeof(Text))]
    //[ExecuteInEditMode]
    public class HelpText : UIBehaviour
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        [TextArea(3, 10)]
        public string text;
        /// <summary>
        /// 字体颜色
        /// </summary>
        public Color m_FontColor = Color.white;


        /// <summary>
        /// 文本类型
        /// </summary>
        public Type m_Type = Type.Text;
        /// <summary>
        /// 金币类型是否采用浮点数显示
        /// </summary>
        public bool Isfloat{ set { m_IsFolat = value; } get { return m_IsFolat; } }
        /// <summary>
        /// 密码文字的最大长度
        /// </summary>
        public int PassLenght { set { m_PassLenght = value; } get { return m_PassLenght; } }
        /// <summary>
        /// 首行缩进字符
        /// </summary>
        public int Text_indent { set { m_Text_indent = value; } get { return m_Text_indent; } }
        /// <summary>
        /// 空格替换处理
        /// </summary>
        public bool IsSpace { set { m_IsSpace = value; } get { return m_IsSpace; } }
        /// <summary>
        /// 显示文本
        /// </summary>
        public Text mText
        {
            get
            {
                if (m_text == null)
                {
                    m_text = this.gameObject.GetComponent<Text>();
                    if (m_text == null)
                    {
                        m_text = this.gameObject.AddComponent<Text>();
                    }
                    m_text.onCullStateChanged.AddListener(OnCullStateChanged);
                }
                return m_text;
            }
        }
        private RectTransform mRect
        {
            get
            {
                if (m_Rect == null)
                {
                    m_Rect = gameObject.GetComponent<RectTransform>();
                    if (m_Rect == null)
                    {
                        m_Rect = gameObject.AddComponent<RectTransform>();
                    }
                }
                return m_Rect;
            }
        }
        
        private RectTransform m_Rect;
        private Text m_text;
        private bool m_IsFolat;
        private int m_PassLenght;
        private int m_Text_indent;
        private bool m_IsSpace;
        private string mJudge_Text;
        private Type mJudge_Type;
        private bool mJudge_Folat;
        private int mJudge_Pass;
        private int mJudge_Indent;
        private bool mJudge_Space;
        private int mJudge_FontSize;


        
        void Update()
        {
            if (JudgeUpDate())
            {
                UpDateText();
            }
        }


#if UNITY_EDITOR
        protected override void OnValidate()
        {
            UpdateProperty();
            UpDateText();
        }
#endif



        //修改RectTransform属性回调
        protected override void OnRectTransformDimensionsChange()
        {
            base.OnRectTransformDimensionsChange();
            UpDateText();
        }
        //修改物体的父级回调
        protected override void OnBeforeTransformParentChanged()
        {
            base.OnBeforeTransformParentChanged();
            UpDateText();
        }

        //protected override void OnValidate()
        //{
        //    base.OnValidate();
        //    UpdateProperty();
        //    UpDateText();
        //}

        /// <summary>
        /// 判断是否更新
        /// </summary>
        private bool JudgeUpDate()
        {
            if (mJudge_Type != m_Type || mJudge_Text != text)
            {
                mJudge_Type = m_Type;
                mJudge_Text = text;
                return true;
            }
            if (mText.color != m_FontColor || mText.fontSize != mJudge_FontSize)
            {
                mText.color = m_FontColor;
                mJudge_FontSize = mText.fontSize;
                return true;
            }
            switch (mJudge_Type)
            {
                case Type.Null:
                    break;
                case Type.Password:
                    if (m_PassLenght != mJudge_Pass)
                    {
                        mJudge_Pass = m_PassLenght;
                        return true;
                    }
                    break;
                case Type.Text:
                    if (mJudge_Indent != m_Text_indent || mJudge_Space != m_IsSpace)
                    {
                        mJudge_Indent = m_Text_indent;
                        mJudge_Space = m_IsSpace;
                        return true;
                    }
                    break;
                case Type.Name:
                    if (mJudge_Space != m_IsSpace)
                    {
                        mJudge_Space = m_IsSpace;
                        return true;
                    }
                    break;
                case Type.Money:
                    if (mJudge_Folat != m_IsFolat)
                    {
                        mJudge_Folat = m_IsFolat;
                        return true;
                    }
                    break;
                default:
                    break;
            }
            return false;

        }
        /// <summary>
        /// 刷新文字
        /// </summary>
        private void UpDateText()
        {
            if (m_Type == Type.Null)
                mText.text = text;
            else if (m_Type == Type.Password)
                PasswordText();
            else if (m_Type == Type.Name)
                NameText();
            else if (m_Type == Type.Money)
                MoneyText();
            else
                TextText();
        }
        /// <summary>
        /// 刷新更改信息
        /// </summary>
        private void UpdateProperty()
        {
            mJudge_Indent = m_Text_indent;
            mJudge_Space = m_IsSpace;
            mJudge_Folat = m_IsFolat;
            mJudge_Pass = m_PassLenght;
            mJudge_Type = m_Type;
            mJudge_Text = text;
            mJudge_FontSize = mText.fontSize;
            mText.color = m_FontColor;
        }

        private void OnCullStateChanged(bool varIsOn)
        {
            Debug.LogError(varIsOn+"++==========》");
        }

        #region 密码文字处理

        /// <summary>
        /// 密码文字
        /// </summary>
        private void PasswordText()
        {
            mText.text = text;
            int lenght = mText.text.Length;
            if (lenght >= m_PassLenght)
                lenght = m_PassLenght;
            string content = "";
            for (int i = 0; i < lenght; i++)
            {
                content += "*";
            }
            mText.text = content;
        }

        #endregion

        #region 文本文字处理

        /// <summary>
        /// 文本文字
        /// </summary>
        private void TextText()
        {
            string temp_content = text;

            string temp_indent = "";
            for (int i = 0; i < m_Text_indent; i++)
            {
                temp_indent = string.Format("{0}{1}", temp_indent, "\u3000");
            }
            temp_content = string.Format("{0}{1}", temp_indent, text);
            if (m_IsSpace)
            {
                temp_content = temp_content.Replace(" ", "\u3000");
            }
            temp_content = temp_content.Replace("\n", "\n" + temp_indent);
            mText.text = temp_content;
        }

        #endregion

        #region 昵称文字处理
        
        /// <summary>
        /// 昵称文字
        /// </summary>
        private void NameText()
        {
            string tempText = text;
            if (m_IsSpace)
            {
                tempText = tempText.Replace(" ", "\u3000");
            }
            mText.text = tempText;
            float temp_Width = mText.preferredWidth;
            if (mRect.rect.width <= 0)
            {
                mText.text = null;
                return;
            }
            if (temp_Width > mRect.rect.width)
            {
                var temp_content = tempText.ToCharArray();
                float width = temp_Width / temp_content.Length;
                int sum = (int)(mRect.rect.width / width);
                string content = new string(temp_content, 0, sum); //text.Substring(0, sum);
                mText.text = content + "...";
                try
                {
                    while (mText.preferredWidth > mRect.rect.width)
                    {
                        sum--;
                        content = new string(temp_content, 0, sum);
                        mText.text = content + "...";
                    }
                }
                catch (Exception e)
                {
                    mText.text = tempText;
                    Debug.LogError(e.Message);
                }
            }
            else
            {
                mText.text = tempText;
            }
        }

        #endregion

        #region 金币文字处理

        /// <summary>
        /// 金币文字
        /// </summary>
        private void MoneyText()
        {
            float Sum = 0;
            float.TryParse(text, out Sum);
            if (Mathf.Abs(Sum) < 10000)
            {
                if (m_IsFolat)
                    if (Sum % 1 != 0)
                        mText.text = string.Format("{0:N2}", Sum);
                    else
                        mText.text = string.Format("{0:N0}", Sum);
                else
                    mText.text = string.Format("{0}", (long)Sum);
            }
            else if ((Mathf.Abs(Sum) >= 10000) && (Mathf.Abs(Sum) < 100000000))
            {
                float a = Sum / 10000.0f;
                if (m_IsFolat)
                {
                    if (Sum % 10000 >= 50 && Sum % 10000 <= 9950)
                        mText.text = string.Format("{0:N2}万", a);
                    else
                        mText.text = string.Format("{0:N0}万", a);
                }
                else
                    mText.text = string.Format("{0}万", (long)a);
            }
            else if ((Mathf.Abs(Sum) >= 100000000) && (Mathf.Abs(Sum) < 1000000000000))
            {
                float a = Sum / 100000000.0f;
                if (m_IsFolat)
                    if (Sum % 100000000.0f >= 10000 * 50 && Sum % 10000 <= 10000 * 9950)
                        mText.text = string.Format("{0:N2}亿", a);
                    else
                        mText.text = string.Format("{0:N0}亿", a);
                else
                    mText.text = string.Format("{0}亿", (long)a);
            }
            else if (Mathf.Abs(Sum) >= 1000000000000)
            {
                float a = Sum / 100000000.0f;
                int idx = 0;
                while (true)
                {
                    idx++;
                    a = a / 10.0f;
                    if (Mathf.Abs((float)a) < 10)
                        break;
                }
                if (m_IsFolat)
                    mText.text = string.Format("{0:N2}^{1}亿", a, idx);
                else
                    mText.text = string.Format("{0}^{1}亿", (long)a, idx);
            }
        }

        #endregion

        

        /// <summary>
        /// 文本类型
        /// </summary>
        public enum Type
        {
            /// <summary>
            /// 默认
            /// 显示最原本的Text不做任何修改
            /// </summary>
            Null,
            /// <summary>
            /// 密码
            /// 使用*代替字符且最多显示6个*
            /// </summary>
            Password,
            /// <summary>
            /// 文本
            /// 可设置首行缩进，空格替换
            /// </summary>
            Text,
            /// <summary>
            /// 昵称
            /// 只会显示一行多出的字体用...显示
            /// </summary>
            Name,
            /// <summary>
            /// 金币
            /// 只显示数字且会显示..万或..亿
            /// 采用浮点数是会保留两位小数
            /// </summary>
            Money
        }
    }
}
