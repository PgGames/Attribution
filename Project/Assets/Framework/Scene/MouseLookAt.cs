using UnityEngine;
using System.Collections;

namespace Framework.Scene
{
    public class MouseLookAt : MonoBehaviour
    {
        #region Fields
        private Vector2 InitAngle;
        public Vector2 m_LimitAngle;                    //限定角度

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
            InitAngle = new Vector2(Screen.width, Screen.height);
            InitAngle = InitAngle / 2.0f;
        }
        //
        //    void Start() 
        //    {
        //    
        //    }
        //    
        void Update()
        {
            UpdateAngleInfo();
        }
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

        private void UpdateAngleInfo()
        {
            Vector2 currentmousePos = Input.mousePosition;
            if (currentmousePos.x <= 0)
                currentmousePos.x = 0;
            else if (currentmousePos.x >= Screen.width)
                currentmousePos.x = Screen.width;
            if (currentmousePos.y <= 0)
                currentmousePos.y = 0;
            else if (currentmousePos.y >= Screen.height)
                currentmousePos.y = Screen.height;


            Vector2 currentAngle = InitAngle - currentmousePos;

            float tempAnglex = -currentAngle.x / InitAngle.x * m_LimitAngle.x;
            float tempAngley = currentAngle.y / InitAngle.y * m_LimitAngle.y;

            this.transform.localEulerAngles = new Vector3(tempAngley, tempAnglex, 0);
        }
        #endregion

        #region Protected & Public Methods

        #endregion
    }
}