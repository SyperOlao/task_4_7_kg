using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Данный класс описывает положение точки в 3х мерном пространстве
 */
namespace task_4_7_kg
{
    class Vector3
    {
        private float []values; 

        public Vector3(float x, float y, float z)
        {
            this.values = new float[] { x, y, z };

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
        public float GetForIndex(int index)
        {
            return values[index];
        }
    }
}
