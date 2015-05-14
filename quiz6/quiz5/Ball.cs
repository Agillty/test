using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz5
{
    class Ball:Shape3D
    {
         //欄位
        private double _radius;

        //建構子
        public Ball(double density, double radius)
            : base(density)
        {
            _radius = radius;
        }
        public Ball()
            : base()
        {
            _radius = 0;
        }

        //屬性
        public double Radius
        {
            //set { _radius = value; }
            get { return _radius; }
        }

        //方法
        public override double Volume()//計算體積
        {
            return 3.0/4.0 *Constant.Pi*_radius * _radius * _radius;
        }
        public override string ShowProperty()//秀屬性
        {
            string output="";
            output += string.Format("{0:8}","Ball")+"\t" + string.Format("{0,8:F2}", _radius) + "\t" + string.Format("{0,8}","") + "\t";
            return output;
        }

    }
}
