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
                maxLumberVolume = value;
            }
        }

        public double Input()
        {

        }

        public double Output()
        {

        }
    }
}
