
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
using UnityEngine.UI;
using System.Collections.Generic;

namespace Kmax
{
    [ExecuteInEditMode]
    public class zSpaceLine : MonoBehaviour
    {
        #region Fields


        public Material m_Material;
        public float m_size;
        public float m_AngleY;
        [SerializeField]
        private Vector3[] m_Pos = new Vector3[2];
        [SerializeField]
        private Transform[] m_Tran = new Transform[2];


        private Canvas m_Canvas;
        private List<Image> m_LineImage = new List<Image>();
        private RectTransform m_Rect;

        #endregion

        #region Properties

        #endregion

        #region Unity Messages
        void Awake()
        {
            OnAwake();
        }
        //    void OnEnable()
        //    {
        //
        //    }
        //
        //    void Start() 
        //    {
        //    
        //    }
        //    
        void Update()
        {
            //ShowLine();
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
        private void OnAwake()
        {
            m_Canvas = GetComponent<Canvas>();
            if (m_Canvas == null)
            {
                m_Canvas = this.gameObject.AddComponent<Canvas>();
                m_Canvas.renderMode = RenderMode.WorldSpace;
            }
            {
                m_Rect = this.GetComponent<RectTransform>();
                if (m_Rect == null)
                    m_Rect = this.gameObject.AddComponent<RectTransform>();
                m_Rect.anchorMin = Vector2.zero;
                m_Rect.anchorMax = Vector2.zero;
                m_Rect.sizeDelta = Vector2.zero;
                m_Rect.position = Vector2.zero;
            }
            var tempGame = GetGames(this.transform);
            for (int i = 0; i < tempGame.Count; i++)
            {
                Destroy(tempGame[i]);
            }
            SettingImage(Vector3.zero);
            SettingImage(Vector3.left * 180);
        }
        private List<GameObject> GetGames(Transform varTran)
        {
            if (varTran == null)
            {
                Debug.Log("Tran is Null");
                return null;
            }
            List<GameObject> TrmpList = new List<GameObject>();
            int TempChildCount = varTran.childCount;
            for (int i = 0; i < TempChildCount; i++)
            {
                Transform TempTran = varTran.GetChild(i);
                TrmpList.Add(TempTran.gameObject);
            }
            return TrmpList;
        }
        private void SettingImage(Vector3 varAngle)
        {
            GameObject go = new GameObject("Image");
            go.transform.SetParent(this.transform);
            RectTransform temp_Rect = go.AddComponent<RectTransform>();
            temp_Rect.position = Vector2.zero;
            temp_Rect.anchorMin = Vector2.zero;
            temp_Rect.anchorMax = Vector2.one;
            temp_Rect.sizeDelta = m_Rect.sizeDelta;
            temp_Rect.localEulerAngles = varAngle;
            m_LineImage.Add(go.AddComponent<Image>());
            //m_LineImage = go.AddComponent<Image>();
            //m_LineImage.material = m_Material;
        }
        private void ShowLine()
        {
            for (int i = 0; i < m_Tran.Length; i++)
            {
                if (m_Tran[i] != null)
                    m_Pos[i] = m_Tran[i].position;
            }
            for (int i = 0; i < m_LineImage.Count; i++)
            {
                m_LineImage[i].material = m_Material;
            }
            Vector3 pos = (m_Pos[0] + m_Pos[1]) / 2.0f;
            this.transform.position = pos;
            m_Rect.sizeDelta = new Vector2(Vector3.Distance(m_Pos[0], m_Pos[1]), m_size);
            this.transform.LookAt(m_Pos[1]);
            this.transform.eulerAngles += new Vector3(-90, m_AngleY, -90);
        }



        #endregion

        #region Protected & Public Methods

        public void SetPos(int varIndex, Vector3 varPos)
        {
            if (varIndex >= m_Pos.Length)
                return;
            else
                m_Pos[varIndex] = varPos;
            ShowLine();
        }


        #endregion
    }
}