using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;
using UnityEngine.Events;

namespace Framework.UI
{
    //[ExecuteInEditMode]
    //[RequireComponent(typeof(Image))]
    [RequireComponent(typeof(Mask))]
    public class RollingBulletin : MonoBehaviour
    {
        [SerializeField]
        public Text m_Text;
        [TextArea(3, 10)]
        public string text;
        public float m_Speed = 0.5f;
        private MoveState m_State;
        //移动量的差值
        public float m_MoveLerp = 100;

        public MoveType m_MoveType = MoveType.Once;

        //要移动的长度
        private float m_MoveLenght = 100;
        //每一字幕的走动时间
        private float m_times = 0;
        private float m_TempTime = 0;


        /// <summary>
        /// 播放完成回调
        /// </summary>
        public PlayCallBack OnCallBack = new PlayCallBack();

        public MoveState State {
            private set
            {
                RectTransform m_Rect = this.GetComponent<RectTransform>();
                if (string.IsNullOrEmpty(text))
                    return;
                if (m_Text == null)
                    return;
                if (value == MoveState.Play)
                {
                    //更新滚动条内容
                    m_Text.text = text;
                    //适配文本宽度
                    m_Text.rectTransform.sizeDelta = new Vector2(m_Text.preferredWidth, m_Text.rectTransform.sizeDelta.y);
                    //计算滚动的移动的距离
                    m_MoveLenght = m_Text.rectTransform.rect.width + m_Rect.rect.width + m_MoveLerp;
                    //设置初始位置
                    m_Text.transform.localPosition = Vector3.zero + new Vector3((m_MoveLenght) / 2, 0, 0);
                    //根据移动速度计算移动的时间
                    m_times = m_MoveLenght / (m_Speed * 1000);
                    m_TempTime = 0;
                }
                else if (value == MoveState.Stop)
                {
                    //更新滚动条内容
                    m_Text.text = text;
                    //适配文本宽度
                    m_Text.rectTransform.sizeDelta = new Vector2(m_Text.preferredWidth, m_Text.rectTransform.sizeDelta.y);
                    //计算滚动的移动的距离
                    m_MoveLenght = m_Text.rectTransform.rect.width + m_Rect.rect.width + m_MoveLerp;
                    //设置初始位置
                    m_Text.transform.localPosition = Vector3.zero + new Vector3((m_MoveLenght) / 2, 0, 0);
                    //根据移动速度计算移动的时间
                    m_times = m_MoveLenght / (m_Speed * 1000);
                    m_TempTime = 0;
                }
                m_State = value;
            }
            get { return m_State; }
        }



        /// <summary>
        /// 播放-（从头开始播放）
        /// </summary>
        /// <param name="varText">播放的内容</param>
        public void OnPlay(string varText)
        {
            text = varText;
            State = MoveState.Play;
        }
        /// <summary>
        /// 暂停-（播放状态下调用）
        /// </summary>
        public void Pause()
        {
            if (m_State == MoveState.Play)
                m_State = MoveState.Pause;
        }
        /// <summary>
        /// 恢复播放-（暂停状态下调用）
        /// </summary>
        public void Play()
        {
            if (m_State == MoveState.Pause)
                m_State = MoveState.Play;
        }
        /// <summary>
        /// 停止-终止播放
        /// </summary>
        public void Stop()
        {
            text = "";
            State = MoveState.Stop;
        }

        
        private void Awake()
        {
            //m_Text = Helper.GetComponent<Text>(this.transform, "Text");
            if (m_Text == null)
            {
                GameObject Go = new GameObject("Text");
                Go.transform.parent = this.transform;
                m_Text = Go.AddComponent<Text>();
            }
            m_Text.alignment = TextAnchor.MiddleCenter;
        }
        // Use this for initialization
        void Start()
        {

        }
        private void OnEnable()
        {
            State = MoveState.Play;
        }
        // Update is called once per frame
        void Update()
        {
            if (m_Text != null)
            {
                if (m_State == MoveState.Play)
                {
                    m_TempTime += Time.deltaTime;
                    m_Text.transform.localPosition = Vector3.Lerp(new Vector3( m_MoveLenght / 2, 0, 0), new Vector3( -m_MoveLenght / 2, 0, 0), m_TempTime / m_times);
                    if (m_TempTime / m_times >= 1)
                    {
                        if (m_MoveType == MoveType.Loop)
                            m_TempTime = 0;
                        else
                            m_State = MoveState.Stop;
                        if (OnCallBack != null)
                            OnCallBack.Invoke();
                    }
                }
            }
        }

        public enum MoveState
        {
            /// <summary>
            /// 停止
            /// </summary>
            Stop,
            /// <summary>
            /// 暂停
            /// </summary>
            Pause,
            /// <summary>
            /// 运动
            /// </summary>
            Play,
        }
        public enum MoveType
        {
            Once,
            Loop
        }
        public class PlayCallBack : UnityEvent
        {
        }
    }

}