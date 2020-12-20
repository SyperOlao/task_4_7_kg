using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Данный класс описывает 3хмерную точку в виде вектора с 4 координатами для матричной алгебры
 */

namespace task_4_7_kg
{
    class Vector4
    {
        private float[] values;

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
            this.values = new float[] { vector.getX(), vector.getY(), vector.getZ(), w };
        }
        public Vector4(Vector3 vector)
        {
            this.values = new float[] { vector.getX(), vector.getY(), vector.getZ(), 0 };
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
        public float getForIndex(int index)
        {
            return values[index];
        }
        public static float EPS = 1e-12f;
        /*
         *  Возвращает нормализованный вектор по компоненте W ветор
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

    }
}
