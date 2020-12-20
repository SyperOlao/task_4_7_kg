using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Данный класс описывает 3хмерную точку в виде вектора с 4 координатами для матричной алгебры
 */

namespace task_4_7_kg
{
    class Vector4
    { 
        private float[] values;
        private const float EPS = 1e-12f;
        private const int SIZE = 4; 

        public Vector4(float x, float y, float z, float w)
        {
            this.values = new float[] { x, y, z, w };
        }
        public Vector4(float x, float y, float z)
        {
            this.values = new float[] { x, y, z, 0 }; 
        }
        public Vector4(Vector3 vector, float w)
        {
            this.values = new float[] { vector.GetX(), vector.GetY(), vector.GetZ(), w };
        }
        public Vector4(Vector3 vector)
        {
            this.values = new float[] { vector.GetX(), vector.GetY(), vector.GetZ(), 0 };
        }
        private Vector4(float[] arr)
        {
            this.values = arr; 
        }

        public float GetX()
        {
            return values[0];
        }
        public float GetY()
        {
            return values[1];
        }
        public float GetZ()
        {
            return values[2];
        }
        public float GetW()
        {
            return values[3];
        }
        public float GetForIndex(int index)
        {
            return values[index];
        }

        /**
         *  Возвращает нормализованный вектор по компоненте W 
         *  @return новый экземпляр {@link Vector4}
         */
        public Vector4 Normalized()
        {
            if (Math.Abs(GetW()) < EPS)
            {
                return new Vector4(GetX(), GetY(), GetZ(), 0);
            }
            return new Vector4(GetX()/GetW(), GetY()/GetW(), GetZ()/GetW(), 1f);
        }
        /**
        *  Возвращает вектор полностью заполнеными нулями
        *  @return нулевой вектор {@link Vector4}
        */
        public static Vector4 ZeroVector()
        {
            return new Vector4(new float[4]);
        }

        public Vector4 Multiplare(float number)
        {
            float[] result = new float[4];
            for (int i = 0; i < SIZE; i++)
                result[i] = this.GetForIndex(i) * number; 
            return new Vector4(result); 
        }
        public Vector4 Addition(float number)
        {
            float[] result = new float[4];
            for (int i = 0; i < SIZE; i++)
                result[i] = this.GetForIndex(i) + number;
            return new Vector4(result);
        }
    }
}
