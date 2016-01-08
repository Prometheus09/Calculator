using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Calculator
    {
        public void TurnOn()
        {
            Console.WriteLine("Calculator is on.");
            Console.WriteLine("Press CTRL-C to exit.");
        }

        public void TurnOff()
        {
            //
        }

        public void PrintOutput(decimal num1, string operand, decimal num2, decimal result)
        {
            Console.WriteLine(String.Format("{0} {1} {2} = {3}", num1, operand, num2, result));
        }
    }

}
