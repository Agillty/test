using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz5
{
    class Cylinder:Shape3D
    {
        //欄位
        private double _radius;
        private double _hight;

        //建構子
        public Cylinder(double density, double radius, double hight)
            : base(density)
        {
            _radius = radius;
            _hight = hight;
        }
        public Cylinder()
            : base()
        {
            _radius = 0;
            _hight = 0;
        }

        //屬性
        public double Radius
        {
            //set { _radius = value; }
            get { return _radius; }
        }
        public double Hight
        {
            //set { _hight = value; }
            get { return _hight; }
        }

        //方法
        public override double Volume()//計算體積
        {
            return Constant.Pi*_radius * _radius * _hight;
        }
        public override string ShowProperty()//秀屬性
        {
            string output="";
            output += string.Format("{0:8}","Cylinder")+"\t"+ string.Format("{0,8:F2}", _radius) +"\t" + string.Format("{0,8:F2}", _hight) + "\t";
            return output;
        }
    }
}
