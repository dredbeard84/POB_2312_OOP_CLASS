using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_02
{
    internal class StockOFLumbers
    {
        private int numberOfStock;
        private string bossName;
        private double maxLumberVolume;
        private double current;

        public int NumberOfStock
        {
            get
            {
                return numberOfStock;
            }
            set
            {
                numberOfStock = value;
            }
        }

        public string BossName
        {
            get
            {
                return bossName;
            }
            set
            {
                bossName = value;
            }
        }

        public double MaxLumberVolume
        {
            get
            {
                return maxLumberVolume;
            }
            set
            {
                if (value > 0)
                {
                    maxLumberVolume = value;
                }
                else
                    throw new Exception("Введите правильный объём");
            }
        }

        public double Current
        {
            get
            {
                return current;
            }
            set
            {
                if (value > maxLumberVolume - current && current + value >= 0)
                {
                    value = maxLumberVolume;
                }
                else
                    current += value;
            }
        }

        public void Add(double volume)
        {
            Current = volume;
        }

        public void Sub(double volume)
        {
            Current = -volume;
        }

        public void Print()
        {
            Console.WriteLine($"Можно завезти {maxLumberVolume - current:F2}. " +
                              $"В наличие {current:F2}.");
        }

    }
}
