using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_7_kg
{
    class PolyLines3D
    {
        private List<Vector3> points; 

        public PolyLines3D(List<Vector3> points)
        {
            this.points = points;
        }
        public List<Vector3> GetPoints()
        {
            return points; 
        }
    }
}
