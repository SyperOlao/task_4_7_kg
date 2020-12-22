using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_7_kg
{
    class ScreenConventer
    {
        private double cornerX, cornerY, realW, realH;
        private int screenW, screenH;

        public ScreenPoint r2c(Vector3 v)
        {
            double x = (v.GetX() - cornerX) * screenW / realW;
            double y = (cornerY - v.GetY()) * screenH / realH;
            return new ScreenPoint((int)x, (int)y); 
        }

        public ScreenConventer(double cornerX, double cornerY, double realW, double realH, int screenW, int screenH)
        {
            this.cornerX = cornerX;
            this.cornerY = cornerY;
            this.realW = realW;
            this.realH = realH;
            this.screenW = screenW;
            this.screenH = screenH;
        }
        
        public double GetCorenerX()
        {
            return cornerX; 
        }
        public double GetCornerY()
        {
            return cornerY; 
        }
        public double GetRealW() { 
            return realW;
        }
        public double GetRealH()
        {
            return realH; 
        }
        public double GetScreenW()
        {
            return screenW;
        }
        public double GetSreenH()
        {
            return screenH;
        }

        public void SetCorenerX(double cornerX)
        {
            this.cornerX = cornerX;
        }
        public void SetCornerY(double cornerY)
        {
            this.cornerY = cornerY;
        }
        public void SetRealW(double realW)
        {
            this.realW = realW;
        }
        public void SetRealH(double realH)
        {
            this.realH = realH;
        }
        public void SetScreenW(int screenW)
        {
            this.screenW = screenW;
        }
        public void SetSreenH(int screenH)
        {
            this.screenH = screenH;
        }

    }
}
