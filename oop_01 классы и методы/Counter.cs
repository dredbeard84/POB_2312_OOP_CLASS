using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_01_классы_и_методы
{
    internal class Counter
    {
        // поля класса
        private int count;
        private int max, min;

        // свойство класса
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                if (min <= value && value <= max)
                {
                    this.count = value;
                }
            }
        }

        // конструктор по умолчанию
        public Counter()
        {
            this.min = -10; // this - обращение к полю класса
            this.max = 10;
            Count = 0;
        }

        // конструктор с параметрами
        public Counter(int c, int min, int max)
        {
            this.min = min;
            this.max = max;
            Count = c;
        }

        public void Increment()
        {
            this.Count++;
        }

        public void Decrement()
        {
            this.Count--;
        }
    }
}
