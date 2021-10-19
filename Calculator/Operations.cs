using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operations
    {
        public double DoOperation(double num1, double num2, string operation)
        {
            //Suporter operations *,/,+,-|
            switch (operation)
            {
                case "+":
                    return num1 + num2;                    
                case "-":
                    return num1 - num2;                    
                case "*":
                    return num1 * num2;                  
                case "/":
                    return num1 / num2;
                default:
                    Console.WriteLine("Introduce una operación valida");
                    return 0;
            }
        }

        public double NList(double [] numb, string [] oper)
        {
            double result = 0;

            result = this.DoOperation(numb[0], numb[1], oper[0]);


            for (int i=2; i<numb.Length; i++)
            {

                result = this.DoOperation(result, numb[i], oper[i-1]);
            }
            return result;
            
        }
    }
}
