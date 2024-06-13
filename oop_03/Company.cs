using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_03
{
    internal class Company
    {
        private Person[]? personal;

        public Person[]
        public Person this[int index];
        {
            get => personal![index];
            set => personal = value;
        }
    }
}
