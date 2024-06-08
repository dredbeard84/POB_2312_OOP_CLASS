using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_01_классы_и_методы
{
    internal class Train
    {
        private string? destination;  // ? - null-безопасность
        private int number;
        private DateTime timeOfdeparture;

        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }

        public int Number
        {
            get => number;
            set => number = value;
        }

        public DateTime TimeOfdeparture
        {
            get => timeOfdeparture;
            set => timeOfdeparture = value;
        }

        public void Print()
        {
            Console.WriteLine($" Назначение: {destination}" +
                              $" Номер: {number}" +
                              $" Время отправления: {timeOfdeparture}");
        }
    }
}