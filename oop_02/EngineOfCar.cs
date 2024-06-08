using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_02
{
    internal class EngineOfCar
    {
        private string? marka;//nameOfCar;
        private double volume;//fuelTank;
        private double current;//currentFuelVolume;
        private double expend;//fuelRate;

        // марка машины
        public string Marka
        {
            get => marka;
            set => marka = value;
        }

        // объём бака
        public double Volume
        {
            get => volume;
            private set    // private, т.к. объём бака не изменяется
            {
                if (value > 0)
                {
                    volume = value;
                }
            }
        }

        // количество топлива в баке
        public double Current
        {
            get => current;
            set
            {
                if (value > volume - current)
                {
                    current = volume;
                    Console.WriteLine("перелил");
                }
                else
                {
                    current += value;
                }
            }
        }

        // расход топлива / 100 км
        public double Expend
        {
            get => expend;
            set
            {
                if (value > 0)
                {
                    expend = value;
                }
            }
        }

        // заправка
        public void Feed(double feed)
        {
            Current = feed;
        }

        // расход на дорогу
        public double Way(double km)
        {
            return km * expend / 100;
        }

        // расход на 100 км
        public double Remains()
        {
            return (current / expend) * 100;
        }

        public EngineOfCar(string marka, double volume, double current, double expend)
        {
            Marka = marka;
            Volume = volume;
            Current = current;
            Expend = expend;
        }
    }
}
