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

        public float getX()
        {
            return values[0]; 
        }
        public float getY()
        {
            return values[1];
        }
        public float getZ()
        {
            return values[2];
        }
        public float getForIndex(int index)
        {
            return values[index];
        }
    }
}
