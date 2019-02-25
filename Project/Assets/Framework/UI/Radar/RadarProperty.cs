using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Framework.UI.Radar
{
    public class RadarProperty : Graphic
    {
        /// <summary>
        /// 图像边的数量
        /// </summary>
        public uint m_Sum = 6;
        /// <summary>
        /// 是否显示背景
        /// </summary>
        public bool m_IsBG { set; get; }
        /// <summary>
        /// 图片的大小
        /// </summary>
        public Vector2 m_Sizes { get; set; }
        /// <summary>
        /// 是否显示属性信息
        /// </summary>
        public bool m_IsProperty = false;
        /// <summary>
        /// 属性图的颜色
        /// </summary>
        public Color32 m_PropertyColor = Color.blue;
        public List<uint> m_MaxValue = new List<uint>();
        public List<float> m_CurrValue = new List<float>();
        /// <summary>
        /// 是否描线
        /// </summary>
        public bool m_IsDrawLine { set; get; }
        /// <summary>
        /// 线的颜色
        /// </summary>
        public Color32 m_LineColor = Color.black;
        /// <summary>
        /// 线的宽度
        /// </summary>
        public float m_LineSize { set; get; }
        /// <summary>
        /// 线的数量
        /// </summary>
        public uint m_LineSum { set; get; }


        protected override void OnPopulateMesh(VertexHelper vh)
        {
            if (!IsActive())
            {
                return;
            }
            if (m_Sum < 3)
            {
                m_Sum = 3;
            }
            vh.Clear();
            var vertexList = new List<UIVertex>();
            ApplyGradient(ref vertexList);
            vh.AddUIVertexTriangleStream(vertexList);
        }
        private void ApplyGradient(ref List<UIVertex> vertices)
        {
            if (m_IsBG)
            {
                BGInfo(ref vertices);
            }
            if (m_IsDrawLine)
            {
                LineInfo(ref vertices);
            }
            if (m_IsProperty)
            {
                PropertyInfo(ref vertices);
            }
        }
        private List<Vector3> GetDrawUIVertex(uint count, Vector2 r)
        {
            List<Vector3> tempvector = new List<Vector3>();

            for (int i = 0; i < count; i++)
            {
                float temp_x = Mathf.Sin((360f * i / count) * Mathf.Deg2Rad) * r.x;//横坐标
                float temp_y = Mathf.Cos((360f * i / count) * Mathf.Deg2Rad) * r.y;//纵坐标
                tempvector.Add(new Vector3(temp_x, temp_y, 0));
            }
            return tempvector;
        }


        private void BGInfo(ref List<UIVertex> vertices)
        {
            List<Vector3> tempvector = GetDrawUIVertex(m_Sum, m_Sizes);
            //bg
            for (int i = 0; i < m_Sum; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    UIVertex tempver = new UIVertex();
                    tempver.color = color;
                    if (j == 0)
                    {
                        tempver.position = tempvector[i];
                    }
                    else if (j == 1)
                    {
                        tempver.position = Vector3.zero;
                    }
                    else if (j == 2)
                    {
                        int index = (int)((i + 1) % m_Sum);
                        tempver.position = tempvector[index];
                    }
                    vertices.Add(tempver);
                }
            }
        }

        private void PropertyInfo(ref List<UIVertex> vertices)
        {
            List<Vector3> tempvector = GetDrawUIVertex(m_Sum, m_Sizes);
            //Property
            for (int i = 0; i < m_Sum; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    UIVertex tempver = new UIVertex();
                    tempver.color = m_PropertyColor;
                    if (j == 0)
                    {
                        tempver.position = tempvector[i] * (m_CurrValue[i] / m_MaxValue[i]);
                    }
                    else if (j == 1)
                    {
                        tempver.position = Vector3.zero;
                    }
                    else if (j == 2)
                    {
                        int index = (int)((i + 1) % m_Sum);
                        tempver.position = tempvector[index] * (m_CurrValue[index] / m_MaxValue[index]); ;
                    }
                    vertices.Add(tempver);
                }
            }
        }

        private void LineInfo(ref List<UIVertex> vertices)
        {
            Vector2 Every = new Vector2(m_Sizes.x / m_LineSum, m_Sizes.y / m_LineSum);
            if (m_LineSum <= 1)
            {
                DrawLine(ref vertices, m_Sizes);
            }
            else
            {
                for (int i = 1; i <= m_LineSum; i++)
                {
                    DrawLine(ref vertices, Every * i);
                }
            }
        }
        private void DrawLine(ref List<UIVertex> vertices,Vector2 varsize)
        {
            Vector2 temp_linesize = new Vector2(varsize.x - m_LineSize, varsize.y - m_LineSize);
            //线的外圈顶点
            List<Vector3> tempOtherVector = GetDrawUIVertex(m_Sum, varsize);
            //线的内圈顶点
            List<Vector3> tempInnerVector = GetDrawUIVertex(m_Sum, temp_linesize);

            for (int i = 0; i < m_Sum; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    UIVertex tempver = new UIVertex();
                    tempver.color = m_LineColor;
                    if (j == 0)
                    {
                        tempver.position = tempOtherVector[i];
                    }
                    else if (j == 1)
                    {
                        tempver.position = tempInnerVector[i];
                    }
                    else if (j == 2)
                    {
                        int index = (int)((i + 1) % m_Sum);
                        tempver.position = tempOtherVector[index];
                    }
                    else if (j == 3)
                    {
                        tempver.position = tempInnerVector[i];
                    }
                    else if (j == 4)
                    {
                        int index = (int)((i + 1) % m_Sum);
                        tempver.position = tempOtherVector[index];
                    }
                    else if (j == 5)
                    {
                        int index = (int)((i + 1) % m_Sum);
                        tempver.position = tempInnerVector[index];
                    }
                    vertices.Add(tempver);
                }
            }
        }
    }
}