using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chief chief = new Chief("Khaled", "Sans", 800);
            Commissionemp Commemp = new Commissionemp("Susan", "Jans", 300, 2, 120);

            Piece_emp piece_emp = new Piece_emp("Samir", "Muan", Convert.ToDecimal(2.8), 150);
            Worker Worker = chief;

            string output = GetString(Worker) + chief + " earned $" + chief.Income().ToString() + "\n\n";

            Worker = Commemp;
            output += GetString(Worker) + Commemp + " earned $" + Commemp.Income().ToString() + "\n\n";

            Worker = piece_emp;
            output += GetString(Worker) + piece_emp + " earned $" + piece_emp.Income().ToString() + "\n\n";

            Console.WriteLine(output, "Polymorphism in use");
        }

        public static string GetString(Worker worker)
        {
            return worker.ToString() + " earned $" + worker.Income().ToString() + "\n";
        }
    }
}
