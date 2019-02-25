using UnityEngine;
using System.Collections;

namespace Framework.Scene
{
    public class MouseRotate : MonoBehaviour
    {
        #region Fields
        
        /// <summary>
        /// 转动方式
        /// </summary>
        public RotateMode m_RotateMode = RotateMode.Auto;
        /// <summary>
        /// 转动轴心
        /// </summary>
        public CenterAxis m_AxisCenter = CenterAxis.ThisTran;
        /// <summary>
        /// 转动的轴向
        /// </summary>
        public AxisDirection m_AxisDirection = AxisDirection.X;
        /// <summary>
        /// 转动速度
        /// </summary>
        public float m_RotateSpeed = 0;
        
        private Vector3 m_MouseCurrentPos;

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
        }
        //
        //    void Start() 
        //    {
        //    
        //    }
        //    
        void Update()
        {
            if (m_RotateMode == RotateMode.Auto)
            {
                AutoRotate();
            }
            else
            {
                ManualRotate();
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// 自动旋转
        /// </summary>
        private void AutoRotate()
        {
            switch (m_AxisDirection)
            {
                case AxisDirection.XY:
                    RotateMore(m_RotateSpeed, m_RotateSpeed, 0);
                    break;
                case AxisDirection.XZ:
                    RotateMore(m_RotateSpeed, 0, m_RotateSpeed);
                    break;
                case AxisDirection.YZ:
                    RotateMore(0, m_RotateSpeed, m_RotateSpeed);
                    break;
                case AxisDirection.X:
                case AxisDirection.Y:
                case AxisDirection.Z:
                default:
                    RotateSingle(m_RotateSpeed);
                    break;
            }
        }
        /// <summary>
        /// 手动旋转
        /// </summary>
        private void ManualRotate()
        {
            if (Input.GetMouseButton(0))
            {
                if (m_MouseCurrentPos == Vector3.zero)
                {
                    m_MouseCurrentPos = Input.mousePosition;
                }
                Vector3 tempcurrentspeed = (Input.mousePosition - m_MouseCurrentPos) * m_RotateSpeed;
                switch (m_AxisDirection)
                {
                    case AxisDirection.X:
                        RotateSingle(tempcurrentspeed.y);
                        break;
                    case AxisDirection.Y:
                        RotateSingle(tempcurrentspeed.x);
                        break;
                    case AxisDirection.Z:
                        RotateSingle(tempcurrentspeed.x);
                        break;
                    case AxisDirection.XY:
                        RotateMore(tempcurrentspeed.y, tempcurrentspeed.x, 0);
                        break;
                    case AxisDirection.XZ:
                        RotateMore(tempcurrentspeed.y, 0, tempcurrentspeed.x);
                        break;
                    case AxisDirection.YZ:
                        RotateMore(0, tempcurrentspeed.x, tempcurrentspeed.y);
                        break;
                    default:
                        break;
                }
                m_MouseCurrentPos = Input.mousePosition;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                m_MouseCurrentPos = Vector3.zero;
            }
        }



        /// <summary>
        /// 多轴旋转
        /// </summary>
        /// <param name="varSpeedx"></param>
        /// <param name="varSpeedy"></param>
        /// <param name="varSpeedz"></param>
        private void RotateMore(float varSpeedx, float varSpeedy, float varSpeedz)
        {
            Vector3 tempAxis = Vector3.forward;
            switch (m_AxisCenter)
            {
                case CenterAxis.ThisTran:
                    this.transform.Rotate(varSpeedx, varSpeedy, varSpeedz);
                    break;
                case CenterAxis.Word:
                    this.transform.RotateAround(this.transform.position, Vector3.right, varSpeedx);
                    this.transform.RotateAround(this.transform.position, Vector3.up, varSpeedy);
                    this.transform.RotateAround(this.transform.position, Vector3.forward, varSpeedz);
                    break;
                case CenterAxis.MainCamera:
                    this.transform.RotateAround(this.transform.position, Camera.main.transform.right, varSpeedx);
                    this.transform.RotateAround(this.transform.position, Camera.main.transform.up, varSpeedy);
                    this.transform.RotateAround(this.transform.position, Camera.main.transform.forward, varSpeedz);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 单轴旋转
        /// </summary>
        /// <param name="varSpeed"></param>
        private void RotateSingle(float varSpeed)
        {
            Vector3 tempAxis = Vector3.forward;
            switch (m_AxisCenter)
            {
                case CenterAxis.ThisTran:
                    switch (m_AxisDirection)
                    {
                        case AxisDirection.X:
                            this.transform.Rotate(varSpeed, 0, 0);
                            break;
                        case AxisDirection.Y:
                            this.transform.Rotate(0, varSpeed, 0);
                            break;
                        case AxisDirection.Z:
                            this.transform.Rotate(0, 0, varSpeed);
                            break;
                        case AxisDirection.XY:
                            this.transform.Rotate(varSpeed, varSpeed, 0);
                            break;
                        case AxisDirection.XZ:
                            this.transform.Rotate(varSpeed, 0, varSpeed);
                            break;
                        case AxisDirection.YZ:
                            this.transform.Rotate(0, varSpeed, varSpeed);
                            break;
                        default:
                            break;
                    }
                    break;
                case CenterAxis.Word:
                    switch (m_AxisDirection)
                    {
                        case AxisDirection.X:
                            tempAxis = Vector3.right;
                            break;
                        case AxisDirection.Y:
                            tempAxis = Vector3.up;
                            break;
                        case AxisDirection.Z:
                            tempAxis = Vector3.forward;
                            break;
                        case AxisDirection.XY:
                            tempAxis = Vector3.right + Vector3.up;
                            break;
                        case AxisDirection.XZ:
                            tempAxis = Vector3.forward + Vector3.up;
                            break;
                        case AxisDirection.YZ:
                            tempAxis = Vector3.right + Vector3.forward;
                            break;
                        default:
                            break;
                    }
                    this.transform.RotateAround(this.transform.position, tempAxis, varSpeed);
                    break;
                case CenterAxis.MainCamera:
                    switch (m_AxisDirection)
                    {
                        case AxisDirection.X:
                            tempAxis = Camera.main.transform.right;
                            break;
                        case AxisDirection.Y:
                            tempAxis = Camera.main.transform.up;
                            break;
                        case AxisDirection.Z:
                            tempAxis = Camera.main.transform.forward;
                            break;
                        default:
                            break;
                    }
                    this.transform.RotateAround(this.transform.position, tempAxis, varSpeed);
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Protected & Public Methods

        #endregion

        


        public enum RotateMode
        {
            /// <summary>
            /// 自动
            /// </summary>
            Auto,
            /// <summary>
            /// 鼠标
            /// </summary>
            Mouse,
        }

        public enum CenterAxis
        {
            /// <summary>
            /// 自身轴向
            /// </summary>
            ThisTran,
            /// <summary>
            /// 世界轴向
            /// </summary>
            Word,
            /// <summary>
            /// 主相机的轴向
            /// </summary>
            MainCamera,
        }
        public enum AxisDirection
        {
            X,
            Y,
            Z,
            XY,
            XZ,
            YZ
        }



    }
}