
using UnityEngine;

namespace Framework
{
    /// <summary>
    /// 单利类型的基类(切换场景时单利不会被清楚)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DontManager<T> : MonoBehaviour where T : Component
    {
        private static T _Manager;
        /// <summary>
        /// 
        /// </summary>
        public static T GetManager
        {
            get
            {
                if (_Manager == null)
                {
                    GetT();
                }
                return _Manager;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static T Managers()
        {
            if (_Manager == null)
            {
                GetT();
            }
            return _Manager;
        }
        private static T GetT()
        {
            var Temp_Type = typeof(T).Name;
            _Manager = GameObject.FindObjectOfType<T>();
            if (_Manager != null)
                return _Manager;
            GameObject Go = new GameObject(Temp_Type);
            _Manager = Go.AddComponent<T>();
            return _Manager;
        }
        void OnDestroy()
        {
            _Manager = null;
        }
        void Awake()
        {
            if (_Manager == null)
                _Manager = this.GetComponent<T>();
            OnAwake();
        }
        /// <summary>
        /// 使用OnAwake代替Awake
        /// </summary>
        protected virtual void OnAwake()
        {
        }
        /// <summary>
        /// 初始化信息在Awake之后调用
        /// </summary>
        public virtual void Init()
        {
        }
    }
}
