using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_7_kg
{
    class DrawPanel 
    {
        private ScreenConventer sc = new ScreenConventer(-1, -1, 2, 2, 800, 600);
        private Scene scene;
        
        public DrawPanel()
        {
            scene = new Scene();
            scene.GetModels().Add(new Vector3(0, 0, 0), new Vector3(1, 0, 0)); 
        }

        public void paint(Graphics graphics)
        {
            //sc.SetScreenW(g)
        }
    }
}
