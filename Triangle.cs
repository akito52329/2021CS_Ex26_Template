using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSampe
{
    class Triangle
    {
        private float bottom;
        private float height;

        /// <summary>
        /// 三角形
        /// </summary>
        /// <param name="w">底辺</param>
        /// <param name="h">高さ</param>
        public Triangle(float w, float h)
        {
            this.bottom = w;
            this.height = h;
        }
        /// <summary>
        /// 三角形の面積
        /// </summary>
        /// <returns>計算</returns>
        public float GetSurface()
        {
            return bottom * height / 2;
        }
    }
}
