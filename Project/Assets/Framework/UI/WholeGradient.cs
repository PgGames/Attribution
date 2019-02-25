using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Framework.UI
{
    /// <summary>
    /// 设置整体的渐变
    /// </summary>
    [AddComponentMenu("Kmax/UI/WholeGradient")]
    public class WholeGradient : BaseMeshEffect
    {
        public List<Color32> m_Color = new List<Color32>();

        /// <summary>
        /// 设置文字的刷新类型
        /// </summary>
        public GradientType m_GradientType = GradientType.TopToDown;

        public override void ModifyMesh(VertexHelper vh)
        {
            if (!IsActive())
            {
                return;
            }
            var vertexList = new List<UIVertex>();
            vh.GetUIVertexStream(vertexList);
            int count = vertexList.Count;
            if (count == 0)
            {
                return;
            }
            ApplyGradient(vertexList, 0, count);
            vh.Clear();
            vh.AddUIVertexTriangleStream(vertexList);
        }
        private void ApplyGradient(List<UIVertex> vertexList, int start, int end)
        {
            Vector4 temp_Vector = new Vector4
            {
                leftx = vertexList[0].position.x,
                rightx = vertexList[0].position.x,
                topy = vertexList[0].position.y,
                bottomy = vertexList[0].position.y,
            };
            
            for (int i = start; i < end; ++i)
            {
                float y = vertexList[i].position.y;
                float x = vertexList[i].position.x;
                if (y > temp_Vector.bottomy)
                {
                    temp_Vector.bottomy = y;
                }
                else if (y < temp_Vector.topy)
                {
                    temp_Vector.topy = y;
                }
                if (x > temp_Vector.leftx)
                {
                    temp_Vector.leftx = x;
                }
                else if (x < temp_Vector.rightx)
                {
                    temp_Vector.rightx = x;
                }
            }
            SettingWholeWord(vertexList, temp_Vector, start, end);
        }
        /// <summary>
        /// 设置整体的颜色
        /// </summary>
        /// <param name="vertexList"></param>
        /// <param name="vector"></param>
        /// <param name="start">起点</param>
        /// <param name="end">终点</param>
        void SettingWholeWord(List<UIVertex> vertexList, Vector4 vector, int start, int end)
        {
            for (int i = start; i < end; ++i)
            {
                UIVertex uiVertex = vertexList[i];
                vertexList[i] = SettingVertexColor(uiVertex, vector);
            }
        }/// <summary>
         /// 设置顶点颜色
         /// </summary>
         /// <param name="uiVertex"></param>
         /// <param name="vector"></param>
         /// <returns></returns>
        private UIVertex SettingVertexColor(UIVertex uiVertex, Vector4 vector)
        {
            float uiElementHeight = Mathf.Abs(vector.topy - vector.bottomy);
            float uiElementWidth = Mathf.Abs(vector.leftx - vector.rightx);
            float temp_Value = 0;
            float temp_Width = 0;
            float temp_Hight = 0;
            switch (m_GradientType)
            {
                case GradientType.TopToDown:
                    temp_Hight = Mathf.Abs(vector.bottomy - uiVertex.position.y);
                    temp_Value = uiElementHeight;
                    break;
                case GradientType.DownToTop:
                    temp_Hight = Mathf.Abs(uiVertex.position.y - vector.topy);
                    temp_Value = uiElementHeight;
                    break;
                case GradientType.LeftToRight:
                    temp_Width = Mathf.Abs(vector.rightx - uiVertex.position.x);
                    temp_Value = uiElementWidth;
                    break;
                case GradientType.RightToLeft:
                    temp_Width = Mathf.Abs(uiVertex.position.x - vector.leftx);
                    temp_Value = uiElementWidth;
                    break;
                case GradientType.LeftSlope:
                    temp_Width = Mathf.Abs(vector.rightx - uiVertex.position.x);
                    temp_Hight = Mathf.Abs(vector.bottomy - uiVertex.position.y);
                    temp_Value = uiElementHeight + uiElementWidth;
                    break;
                case GradientType.RightSlope:
                    temp_Width = Mathf.Abs(uiVertex.position.x - vector.leftx);
                    temp_Hight = Mathf.Abs(vector.bottomy - uiVertex.position.y);
                    temp_Value = uiElementHeight + uiElementWidth;
                    break;
                //case GradientType.HeartCircle:
                //    float tempheartcenterx = (vector.leftx + vector.rightx) / 2.0f;
                //    float tempheartcentery = (vector.topy + vector.bottomy) / 2.0f;
                //    temp_Width = Mathf.Abs(uiVertex.position.x - tempheartcenterx);
                //    temp_Hight = Mathf.Abs(uiVertex.position.y - tempheartcentery);
                //    temp_Value = uiElementHeight + uiElementWidth;
                //    break;
                //case GradientType.OuterCircle:
                default:
                    break;
            }
            if (m_Color.Count >= 2)
            {

                if (m_Color.Count == 2)
                {
                    uiVertex.color = Color32.LerpUnclamped(m_Color[0], m_Color[1], (temp_Width + temp_Hight) / temp_Value);
                }
                else
                {
                    float tempvalue = temp_Value / (m_Color.Count - 1);
                    int tempindex = (int)((temp_Width + temp_Hight) / tempvalue - ((temp_Width + temp_Hight) / tempvalue) % 1);
                    if (tempindex == m_Color.Count - 1)
                    {
                        tempindex -= 1;
                    }
                    float tempsum = (temp_Width + temp_Hight) - (tempvalue * tempindex);
                    uiVertex.color = Color32.LerpUnclamped(m_Color[tempindex], m_Color[tempindex + 1], tempsum / tempvalue);
                }
            }
            return uiVertex;
        }

        public enum GradientType
        {
            TopToDown,
            DownToTop,
            LeftToRight,
            RightToLeft,
            LeftSlope,
            RightSlope,
        }
        public struct Vector4
        {
            public float leftx;
            public float rightx;
            public float topy;
            public float bottomy;
        }
    }
}