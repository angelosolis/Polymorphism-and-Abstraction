using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Chief : Worker
    {
        private decimal salary;

        public Chief(string FSname, string LSname, decimal salary): base(FSname, LSname)
        {
            Weeklyincome = salary;
        }

        public override decimal Income()
        {
            return Weeklyincome;
        }

        public decimal Weeklyincome
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                    salary = value;
            }
        }

        public override string ToString()
        {
            return "Chief: " + base.ToString();
        }
    }
}
