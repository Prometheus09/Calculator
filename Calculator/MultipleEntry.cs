using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Calculator
{
    class MultipleEntry
    {

        public void AnswerStringProblem()
        {

            try
            {
                int i = 0;

                while (i < 1)
                {


                    Console.WriteLine("Enter a string of math to do: ");
                    string math = Console.ReadLine();
                    string value = new DataTable().Compute(math, null).ToString();
                    Console.WriteLine("Your answer is: " + value);
                    Console.WriteLine("\nWant to go again? 'Y' or 'N'");
                    string response = Console.ReadLine().ToLower();
                    if (response == "y")
                    {
                        i = 0;
                    }
                    else if (response == "n")
                    {
                        i++;
                    }
                    else if (response != "y" || response != "n")
                    {
                        Console.WriteLine("Invalid entry");
                        Console.ReadLine();
                        i = 0;
                    }




                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            
            

        }
    }
}
