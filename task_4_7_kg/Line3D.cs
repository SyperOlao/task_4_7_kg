using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_7_kg
{
    public class Line3D : IModel
    {
        private Vector3 p1, p2;

        public Line3D(Vector3 p1, Vector3 p2)
        {
            this.p1 = p1;
            this.p2 = p2; 
        }

        public Vector3 GetP1()
        {
            return p1; 
        }

        public void SetP1(Vector3 p1)
        {
            this.p1 = p1;
        }
        public Vector3 GetP2()
        {
            return p2;
        }
        public void SetP2(Vector3 p2)
        {
            this.p2 = p2;
        }
    }
}
