using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz5
{
    public class Shape3D
    {
        //欄位
        protected double _density;
        public static int Amount = 0;

        //建構子
        public Shape3D(double density)//有密度
        {
            _density = density;
            Amount++;
        }
        public Shape3D()//沒密度
        {
            _density = 0;
            Amount++;
        }

        //屬性
        public double  Density
        {
            set 
            {
                if (value > 0)
                    _density = value;
                else
                    return ;
            }
            get { return _density; }
        }

        //方法
        public virtual double Volume()
        {
            return 0.0;
        }
        public double Weight()
        {
            return Volume() * _density;
        }
        public virtual string ShowProperty()
        {
            return "";
        }
        public string ShowResult()
        {
            string output = ShowProperty();
            output += string.Format("{0,8:F2}", Density) + "\t"
                + string.Format("{0,8:F2}", Volume()) + "\t"
                + string.Format("{0,8:F2}", Weight());
            return output;
        }
    }
}
