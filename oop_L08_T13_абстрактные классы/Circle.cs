using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_L08_T13_абстрактные_классы
{
    internal class Circle : D2
    {
        public double Radius { get; set; }

        public override double getArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double getPerimetr()
        {
            return 2 * Math.PI * Radius;
        }

    }
}
