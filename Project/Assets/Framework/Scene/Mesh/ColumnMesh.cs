using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Framework.Scene.Mesh
{
    public class ColumnMesh : MonoBehaviour//Graphic//Renderer //
    {
        //LineRenderer
        public UnityEngine.Mesh m_Mesh;
        public MeshFilter meshFilter;

        public uint m_Sum = 3;
        public float m_Heiht = 1;
        public float m_Size = 1;
        public Color color = Color.white;
        public Color m_colors;


        private void Start()
        {
            var vertexList = new List<UIVertex>();
            ApplyGradient(ref vertexList, m_Size, m_Heiht / 2.0f);
            Debug.LogError(vertexList.Count);
            m_Mesh.vertices = Switchpos(vertexList).ToArray();
        }

        public void Update()
        {
            //meshFilter.sharedMesh.vertices = Switchpos(vertexList).ToArray();
        }

        //protected override void OnPopulateMesh(VertexHelper vh)
        //{
        //    if (!IsActive())
        //    {
        //        return;
        //    }
        //    if (m_Sum < 3)
        //    {
        //        m_Sum = 3;
        //    }
        //    vh.Clear();
        //    var vertexList = new List<UIVertex>();
        //    BGInfo(ref vertexList, m_Size, m_Heiht / 2.0f);
        //    DrawLine(ref vertexList, m_Size, m_Heiht / 2.0f);
        //    BGInfo(ref vertexList, m_Size, m_Heiht / -2.0f);
        //    vh.AddUIVertexTriangleStream(vertexList);
        //}
        public List<Vector3> Switchpos(List<UIVertex> vertices)
        {
            List<Vector3> vectors = new List<Vector3>();
            for (int i = 0; i < vertices.Count; i++)
            {
                vectors.Add(vertices[i].position);
            }
            return vectors;
        }



        private void ApplyGradient(ref List<UIVertex> vertices, float r, float h)
        {
            BGInfo(ref vertices, r, h);
            DrawLine(ref vertices, r, h);
            BGInfo(ref vertices, r, -h);
        }

        private void BGInfo(ref List<UIVertex> vertices, float r, float h)
        {
            List<Vector3> tempvector = GetDrawUIVertex(m_Sum, r, h);
            //上面
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
                        tempver.position = new Vector3(0, 0, h);
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
        private List<Vector3> GetDrawUIVertex(uint count, float r,float h)
        {
            List<Vector3> tempvector = new List<Vector3>();

            for (int i = 0; i < count; i++)
            {
                float temp_x = Mathf.Sin((360f * i / count) * Mathf.Deg2Rad) * r;//横坐标
                float temp_y = Mathf.Cos((360f * i / count) * Mathf.Deg2Rad) * r;//纵坐标
                tempvector.Add(new Vector3(temp_x, temp_y, h));
            }
            return tempvector;
        }
        private void DrawLine(ref List<UIVertex> vertices, float r, float h)
        {
            //Vector2 temp_linesize = new Vector2(varsize.x - m_LineSize, varsize.y - m_LineSize);
            //线的外圈顶点
            List<Vector3> tempOtherVector = GetDrawUIVertex(m_Sum, r, h);
            //线的内圈顶点
            List<Vector3> tempInnerVector = GetDrawUIVertex(m_Sum, r, -h);

            for (int i = 0; i < m_Sum; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    UIVertex tempver = new UIVertex();
                    tempver.color = m_colors;
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