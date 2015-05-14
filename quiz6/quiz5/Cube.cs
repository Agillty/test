using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz5
{
    class Cube:Shape3D
    {
           //欄位
        private double _side;

        //建構子
        public Cube(double density, double radius)
            : base(density)
        {
            _side = radius;
        }
        public Cube()
            : base()
        {
            _side = 0;
        }

        //屬性
        public double Side
        {
            //set { _radius = value; }
            get { return _side; }
        }

        //方法
        public override double Volume()//計算體積
        {
            return _side * _side * _side;
        }
        public override string ShowProperty()//秀屬性
        {
            string output = "";
            output += string.Format("{0:8}", "Cube") + "\t" + string.Format("{0,8:F2}", _side) + "\t" + string.Format("{0,8}", "") + "\t";
            return output;
        }
   
    }
}
