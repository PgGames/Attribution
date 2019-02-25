
#region 版权信息
/*
 * -----------------------------------------------------------
 *  Copyright (c) KeJun All rights reserved.
 * -----------------------------------------------------------
 *		描述: 
 *      创建者：
 *      创建时间: 2019-01-25 09:46:00
 *  
 */
#endregion


using UnityEngine;
using System.Collections;
using Framework;

namespace ProjectModule.Name.UI
{
    public class Demo : MonoBehaviour
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Unity Messages
        //    void Awake()
        //    {
        //
        //    }
        //    void OnEnable()
        //    {
        //
        //    }
        //
        void Start()
        {
            //Framework.Systems.Hardware temp = new Framework.Systems.Hardware();
            //Debug.LogError(temp.GetHardwareID());
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debuger.Log("==========");
            }
        }

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

        #endregion

        #region Protected & Public Methods

        public void Btn_OPen()
        {
            //Application.OpenURL(Application.streamingAssetsPath + "/DefaultCompany.exe");
        }


        #endregion
    }
}