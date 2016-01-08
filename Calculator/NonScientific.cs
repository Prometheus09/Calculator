using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class NonScientific : Calculator
    {
        public decimal result2 = 0;
        public decimal Add(decimal x, decimal y)
        {
           
                return x + y;
            
        }

        public decimal Subtract(decimal x, decimal y)
        {
         
                return x - y;
         
        }

        public decimal Multiply(decimal x, decimal y)
        {
         
                return x * y;
         
        }

        public decimal Divide(decimal x, decimal y)
        {
          
                return x / y;
                      
        }

        public void Calculate()
        {
            do
            {
                try
                {
                    Console.Write("Please enter the first number: ");
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Please enter an operand (+, -, /, *): ");
                    string operand = Console.ReadLine();
                    Console.Write("Please enter the second number: ");
                    decimal num2 = Convert.ToDecimal(Console.ReadLine());
                    decimal result = 0;
                   

                    switch (operand)
                    {
                        case "-":
                            result = this.Subtract(num1, num2);
                            result2 = this.Subtract(num1, num2);
                            this.PrintOutput(num1, operand, num2, result);
                            CalculateContinue();
                            break;
                        case "+":
                            result = this.Add(num1, num2);
                            result2 = this.Add(num1, num2);
                            this.PrintOutput(num1, operand, num2, result);
                            CalculateContinue();
                            break;
                        case "/":
                            result = this.Divide(num1, num2);
                            result2 = this.Divide(num1, num2);
                            this.PrintOutput(num1, operand, num2, result);
                            CalculateContinue();
                            break;
                        case "*":
                            result = this.Multiply(num1, num2);
                            result2 = this.Multiply(num1, num2);
                            this.PrintOutput(num1, operand, num2, result);
                            CalculateContinue();
                            break;
                        default:
                            Console.WriteLine("Wrong operand pressed");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine(); 


            } while (true);
        }

        public void AskToContinue()
        {
            int i=0;
            while(i<1)
            {

        
            Console.WriteLine("\nDo you want to Continue: 'Y' or 'N'");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                i++;
            }
            else if (answer == "n")
            {
                Environment.Exit(0);
            }
            else if(answer != "y" || answer != "n" )
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("\nYou still have: " + result2);
            }
            
                    }
        }
        public void CalculateContinue()
        {
            do
            {
                try
                {
                    
                    Console.Write("\nYou still have: " + result2);
                    AskToContinue();
                    Console.Write("\n\nPlease enter another operand (+, -, /, *): ");
                    string operand = Console.ReadLine();
                    Console.Write("\nPlease enter another number: ");
                    decimal num2 = Convert.ToDecimal(Console.ReadLine());
                    decimal result = 0;
                    

                    switch (operand)
                    {
                        case "-":
                            result = this.Subtract(result2, num2);
                            this.PrintOutput(result2, operand, num2, result);
                            result2 = result;
                            break;
                        case "+":
                            result = this.Add(result2, num2);
                            this.PrintOutput(result2, operand, num2, result);
                            result2 = result;
                            break;
                        case "/":
                            result = this.Divide(result2, num2);
                            this.PrintOutput(result2, operand, num2, result);
                            result2 = result;
                            break;
                        case "*":
                            result = this.Multiply(result2, num2);
                            this.PrintOutput(result2, operand, num2, result);
                            result2 = result;
                            break;
                        default:
                            Console.WriteLine("Wrong operand pressed");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();


            } while (true);
        }
    }
}
