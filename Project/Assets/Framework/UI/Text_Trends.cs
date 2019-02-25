using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections.Generic;

namespace Framework.UI
{
    [AddComponentMenu("Helper/UI/TextTrends")]
    public class Text_Trends : MonoBehaviour
    {
        #region Fields

        public uint m_TextIndent;       //首行缩进--字符数
        [TextArea(4, 10)]
        public string m_Text;           //显示的文本内容
        public bool m_Enable;           //是否在OnEnable中初始化Play
        public Text m_Conetnt;          //用于显示的文本
        [Header("字/每秒")]
        public float m_ShowSpeed = 1;   //动态文字的速度


        public CallBack m_CallBack = new CallBack();

        public ScrollRect m_ScrollRect;
        
        private char[] m_Text_Char;
        private bool suspend = false;
        private float m_Index = 0;

        #endregion

        #region Properties

        #endregion

        #region Unity Messages
        //    void Awake()
        //    {
        //
        //    }
        void OnEnable()
        {
            if (m_Enable)
                Play(0);
        }
        //
        //    void Start() 
        //    {
        //    
        //    }
        //    
        //    void Update() 
        //    {
        //    
        //    }
        //
        //    void OnDisable()
        //    {
        //
        //    }
        //
        //    void OnDestroy()
        //    {
        //
        //    }

        #endregion

        #region Private Methods


        /// <summary>
        /// 重新播放
        /// </summary>
        private void Play(float varLenght)
        {
            StopCoroutine("Player");
            suspend = false;
            string str = m_Text.Replace(" ", "\u3000");
            string LineHead = "";
            if (m_TextIndent != 0)
            {
                for (int i = 0; i < m_TextIndent; i++)
                {
                    LineHead += "\u3000";
                }
                str = str.Replace("\n", "\n" + LineHead);
                str = LineHead + str;
            }
            m_Text_Char = str.ToCharArray();
            if (varLenght != 0)
            {
                var tempText = new List<char>(m_Text_Char);
                float templenght = tempText.Count;
                for (int i = 0; i < tempText.Count; i++)
                {
                    if (tempText[i] == '\n' || tempText[i] == ' ' || tempText[i] == '\u3000')
                    {
                        templenght--;
                    }
                }
                m_ShowSpeed = templenght / varLenght;
            }
            StartCoroutine("Player");
        }

        IEnumerator Player()
        {
            if (m_Conetnt != null)
            {
                m_Index = 0;
                m_Conetnt.text = "";
                yield return 0;
                RectTransform TempCententRect = null;
                RectTransform TempScrollRect = null;
                if (m_ScrollRect != null)
                {
                    TempCententRect = m_ScrollRect.content.GetComponent<RectTransform>();
                    TempScrollRect = m_ScrollRect.GetComponent<RectTransform>();
                    if (m_ScrollRect.verticalScrollbar != null)
                        m_ScrollRect.verticalScrollbar.direction = Scrollbar.Direction.BottomToTop;
                }
                while (m_Index <= m_Text_Char.Length)
                {
                    if (suspend)
                    {
                        yield return new WaitForFixedUpdate();
                        continue;
                    }

                    float TempTimes = Time.fixedDeltaTime;
                    float currfont = TempTimes * m_ShowSpeed;
                    m_Index += currfont;
                    string currcentent = new string(m_Text_Char, 0, (int)m_Index);
                    for (int i = (int)m_Index; i < m_Text_Char.Length; i++)
                    {
                        //if (i <= m_Index)
                        //    currcentent += m_Text_Char[i];
                        /*else */
                        if (m_Text_Char[i] == '\n' || m_Text_Char[i] == ' ' || m_Text_Char[i] == '\u3000')
                            m_Index += 1;
                        else
                            break;
                    }
                    m_Conetnt.text = currcentent;
                    if (m_ScrollRect != null)
                    {
                        TempCententRect.sizeDelta = new Vector2(TempCententRect.sizeDelta.x, m_Conetnt.preferredHeight);
                        if (TempCententRect.sizeDelta.y > TempScrollRect.sizeDelta.y)
                        {
                            if (m_ScrollRect.verticalScrollbar != null)
                            {
                                m_ScrollRect.verticalScrollbar.direction = Scrollbar.Direction.BottomToTop;
                                m_ScrollRect.verticalScrollbar.value = 0;
                            }
                        }
                    }
                    yield return new WaitForFixedUpdate();
                }
                if (m_ScrollRect != null)
                {
                    TempCententRect.sizeDelta = new Vector2(TempCententRect.sizeDelta.x, m_Conetnt.preferredHeight);
                    if (TempCententRect.sizeDelta.y > TempScrollRect.sizeDelta.y)
                    {
                        if (m_ScrollRect.verticalScrollbar != null)
                            m_ScrollRect.verticalScrollbar.value = 0;
                    }
                }
                yield return 0;
                m_CallBack.Invoke();
            }
        }

        #endregion

        #region Protected & Public Methods
        /// <summary>
        /// 重新播放
        /// </summary>
        public void RePlay()
        {
            StopCoroutine("Player");
            suspend = false;
            StartCoroutine("Player");
        }
        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="varCentent">播放的内容</param>
        public void Play(string varCentent)
        {
            m_Text = varCentent;
            Play(0);
        }
        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="varCentent">播放的内容</param>
        /// <param name="varTimeLengt">播放总时长</param>
        public void Play(string varCentent, float varTimeLengt)
        {
            m_Text = varCentent;
            Play(varTimeLengt);
        }

        /// <summary>
        /// 暂停播放
        /// </summary>
        public void Pause()
        {
            suspend = true;
        }
        /// <summary>
        /// 恢复播放
        /// </summary>
        public void Recovery()
        {
            suspend = false;
        }
        /// <summary>
        /// 跳过播放
        /// </summary>
        public void Skip()
        {
            m_Index = m_Text_Char.Length;
        }
        /// <summary>
        /// 停止播放（无法继续）
        /// </summary>
        public void Stop()
        {
            StopAllCoroutines();
        }

        #endregion



        public class CallBack : UnityEvent
        {
            public CallBack()
            {
            }
        }
    }
}