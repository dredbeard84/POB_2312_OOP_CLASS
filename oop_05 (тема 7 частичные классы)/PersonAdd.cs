using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_05__тема_7_частичные_классы_
{
    internal partial class Person
    {
        public partial void Read()
        {
            Console.WriteLine("Я читаю");
        }
        public void Eat()
        {
            Console.WriteLine("Я ем");
        }
    }
}
