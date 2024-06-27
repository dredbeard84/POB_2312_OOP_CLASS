using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_L08_T13_абстрактные_классы
{
    internal class Rectangle : D2
    {
        private double width;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value >0)
                {
                    width = value;
                }
            }
        }

        private double height;

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >0)
                {
                    height = value;
                }
            }
        }

        public override double getArea()
        {
            return Width * Height;
        }

        public override double getPerimetr()
        {
            return 2 * (Width + Height);
        }
    }
}
