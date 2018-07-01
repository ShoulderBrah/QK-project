using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public class Point2D
    {
        private double x;
        private double y;
        private RandomG num = new RandomG();
        public Point2D()
        {
            this.X = num.RandomNumbers(-100,100);
            this.Y = num.RandomNumbers(-100, 100);
        }

        public Point2D(double x,double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double  X
        {
             get
            {
                return this.x;
            }
             set
             {
                this.x = value;
            }
        }

        public double Y
        {
             get
            {
                return this.y;
            }
             set
            {
                this.y = value;
            }
        }


        public override string ToString()
        {
            return "("+Math.Round(this.X,2)+","+ Math.Round(this.Y,2)+")";
        }
    }
}
