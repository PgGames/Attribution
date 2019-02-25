
#region 版权信息
/*
 * -----------------------------------------------------------
 *  Copyright (c) KeJun All rights reserved.
 * -----------------------------------------------------------
 *		描述: 
 *      创建者：#DEVELOPERNAME#
 *      创建时间: #CREATIONDATE#
 *  
 */
#endregion


using UnityEngine;
using System.Collections;
using Framework.UI;
using UnityEngine.UI;

namespace Demo
{
    public class Demo : MonoBehaviour
    {
        #region Fields
        public HelpText m_Text;
        public InputField m_Input;
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
            //for (int i = 0; i < Screen.resolutions.Length; i++)
            //{
            //    //Debug.Log("width:"+Screen.resolutions[i].width+"-->height:"+ Screen.resolutions[i].height);
            //    //Debug.LogError(Screen.resolutions[i].height);
            //}
        }

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

        #endregion

        #region Protected & Public Methods
        public void Btn_IsOn(bool varIsOn)
        {
            m_Text.Isfloat = varIsOn;
        }
        public void Btn_Up()
        {
            m_Text.text = m_Input.text;

        }
        #endregion
    }
}