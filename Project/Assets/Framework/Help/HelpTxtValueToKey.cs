using Framework.Manager;
using Framework.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Framework.Help
{
    /// <summary>
    /// 根据Key值获取其对应的Value值与LanguageManager联合使用
    /// </summary>
    [AddComponentMenu("Manager/Help/TextValue")]
    [RequireComponent(typeof(Text))]
    public class HelpTxtValueToKey : MonoBehaviour
    {
        [SerializeField]
        private string Key;

        public string GetKey { get { return Key; } }
        /// <summary>
        /// 
        /// </summary>
        public Text m_Content;
        public HelpText m_Centent;

        private void Awake()
        {
            LanguageManager.GetManager.Add(GetValueToKey);
            m_Centent = this.transform.GetComponent<HelpText>();
            if (m_Centent == null)
            {
                if (m_Content == null)
                {
                    m_Content = this.transform.GetComponent<Text>();
                }
            }
            GetValueToKey();
        }
        /// <summary>
        /// 设置Key值并更新Value
        /// </summary>
        /// <param name="varKey"></param>
        public void SettingKey(string varKey)
        {
            Key = varKey;
            GetValueToKey();
        }
        private void OnEnable()
        {
            if (!string.IsNullOrEmpty(Key))
            {
                GetValueToKey();
            }
        }
        private void GetValueToKey()
        {
            string Value = LanguageManager.GetManager.GetValueToKey(Key);
            if (m_Centent != null)
            {
                m_Centent.text = Value;
            }
            if (m_Content != null)
            {
                m_Content.text = Value;
            }
        }
    }
}
