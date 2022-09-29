using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public void Add()
        {
            Console.WriteLine("Enter 2 integers to add");
            var addNumber1 = Console.ReadLine();
            var addNumber2 = Console.ReadLine();
            
            if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
            {
                int result = addNumOne + addNumTwo;
                Console.Write($"{addNumber1} + {addNumber2} = {result}");
                
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }
        
        public void Subtract()
        {
            Console.WriteLine("Enter 2 integers to subtract");
            var subtractNumber1 = Console.ReadLine();
            var subtractNumber2 = Console.ReadLine();

            if (int.TryParse(subtractNumber1, out int subNumOne) && int.TryParse(subtractNumber2, out int subNumTwo))
            {
                int result = subNumOne - subNumTwo;
                Console.Write($"{subtractNumber1} - {subtractNumber2} = {result}");
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }

        public void Multiply()
        {
            Console.WriteLine("Enter 2 integers to multiply");
            var multiplyNumber1 = Console.ReadLine();
            var multiplyNumber2 = Console.ReadLine();

            if (int.TryParse(multiplyNumber1, out int multNumOne) && int.TryParse(multiplyNumber2, out int multNumTwo))
            {
                int result = multNumOne * multNumTwo;
                Console.Write($"{multiplyNumber1} * {multiplyNumber2} = {result}");
                }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }

        public void Divide()
        {
            Console.WriteLine("Enter 2 integers to divide");
            var divideNumber1 = Console.ReadLine();
            var divideNumber2 = Console.ReadLine();

            if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
            {
                double result = divNumOne / divNumTwo;
                Console.Write($"{divideNumber1} / {divideNumber2} = {result}");
                }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }
    }
}
