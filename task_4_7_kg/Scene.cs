using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task_4_7_kg
{
    class Scene
    {
        private List<IModel> models = new List<IModel>();

        public List<IModel> GetModels()
        {
            return models; 
        }
        
        public void DrawWord(ICamera camera, IDrawer drawer)
        {
            List<PolyLines3D> allLines = new List<PolyLines3D>(); 
            foreach(IModel m in models)
            {
                foreach (PolyLines3D pl in m.GetLines())
                {
                    List<Vector3> nv = new List<Vector3>();
                    foreach (Vector3 v in pl.GetPoints())
                    {
                        nv.Add(camera.w2c(v));
                    }
                    allLines.Add(new PolyLines3D(nv)); 
                }
            }
            drawer.Draw(allLines);
        }
    }
}
