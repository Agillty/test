using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz5
{
    class Pyramid:Shape3D
    {
         //欄位
        private double _side;
        private double _hight;

        //建構子
        public Pyramid(double density, double side, double hight)
            : base(density)
        {
            _side = side;
            _hight = hight;
        }
        public Pyramid()
            : base()
        {
            _side = 0;
            _hight = 0;
        }

        //屬性
        public double Side
        {
            //set { _radius = value; }
            get { return _side; }
        }
        public double Hight
        {
            //set { _hight = value; }
            get { return _hight; }
        }

        //方法
        public override double Volume()//計算體積
        {
            return (1.0/3.0) * _side * _side * _hight;
        }
        public override string ShowProperty()//秀屬性
        {
            string output="";
            output += string.Format("{0:8}", "Pyramid") + "\t" + string.Format("{0,8:F2}", _side) + "\t" + string.Format("{0,8:F2}", _hight) + "\t";
            return output;
        }
  
    }
}
