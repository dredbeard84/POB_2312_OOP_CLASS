using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_L08_T13_абстрактные_классы
{
    abstract class Figure
    {
        public string? Name { get; set; }

        public abstract double getArea();

    }
}
