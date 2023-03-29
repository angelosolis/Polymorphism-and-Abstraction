using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Piece_emp : Worker
    {
        private decimal Paymentforpiece;
        private int amount;

        public Piece_emp(string FSnameval, string LSnameval, decimal PaymentforP, int amount) : base(FSnameval, LSnameval)
        {
            Paymentforpiece = PaymentforP;
            Amount = amount;
        }

        public decimal PaymentforP
        {
            get
            {
                return Paymentforpiece;
            }
            set
            {
                if(value > 0)
                {
                    Paymentforpiece = value;
                }
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
            return Amount * Paymentforpiece;
        }

        public override string ToString()
        {
            return "Piece emp: " +  base.ToString();
        }
    }
}
