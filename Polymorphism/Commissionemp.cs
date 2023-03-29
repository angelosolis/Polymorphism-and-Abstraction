using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Commissionemp : Worker
    {
        private decimal salary;
        private decimal commission;
        private int amount;

        public Commissionemp(string FSnameval, string LSnameval,decimal salary, decimal commission, int amount) : base(FSnameval, LSnameval)
        {
            Weeklyincome = salary;
            Commission = commission;
            Amount = amount;
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

        public decimal Commission 
        { 
            get 
            { 
                return commission; 
            } 
            set
            {
                if (value > 0)
                    commission = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value > 0)
                    amount = value;
            }
        }

        public override decimal Income()
        {
           return Weeklyincome + Commission * Amount;
        }

        public override string ToString()
        {
            return "Commissionemp: " + base.ToString();
        }
    }
}
