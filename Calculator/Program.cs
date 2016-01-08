using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            NonScientific ncalc = new NonScientific();
            MultipleEntry mcalc = new MultipleEntry();
            ncalc.TurnOn();
            Console.WriteLine("1) Only two numbers then one at a time   2) Enter a string equation");
            string response = Console.ReadLine();
            if (response == "1")
            {
                ncalc.Calculate();
            }
            else if (response == "2")
            {
                mcalc.AnswerStringProblem();
            }
            
        }
    }
}
