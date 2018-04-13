using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    class Program
    {
        //variable input
        static int number1 = 0;
        static int number2 = 0;
        //This method is used to output
        static void Output()
        {
            int[] num1Array = GetIntArray(number1);
            int[] num2Array = GetIntArray(number2);
            int Sum = num1Array[0] + num2Array[0];
			//sum of first two digits for comparison.
            for (int i = 1; i < num1Array.Length; i++)
            {
                if (Sum != (num1Array[i] + num2Array[i]))
                { 
                    Console.WriteLine("False.");
                    return;
                }
            }
            Console.WriteLine("True.");
        }
        //check that both numbers have same length or not
        static bool CheckLength()
        {
            if (number1.ToString().Length != number2.ToString().Length)
            {
                return false;
            }
            else { return true; }
        }
        //receives the number and return array of digits
        static int[] GetIntArray(int num)
        {
            //create list of int
            List<int> listOfInts = new List<int>();
            //loop starts when num greater than 0
            while (num > 0)
            {
         //divide the number by 10 then save the reminder
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
			//reverse the list
            return listOfInts.ToArray();
			//return the string 
        }
        static void Input()
        {
            //repeat the input if not a right number
            bool Repeat = false;
            //the loop to see if user enter correct number or not
            do
            {
                //ask user to input
                Console.WriteLine("Enter first number: ");
                if (!Int32.TryParse(Console.ReadLine(), out number1))
                {
                    Repeat = true;
                }
                else
                { Repeat = false; }
            } while (Repeat);
            //for second input number set the Repeat to false
            Repeat = false;
            do
            {
                //ask user to input
                Console.WriteLine("Enter second number: ");
                if (!Int32.TryParse(Console.ReadLine(), out number2))
                {
                    Repeat = true;
                }
                else
                {
                    //if lenght is the same don't repeat
                    if (CheckLength())
                    {
                        Repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Number of digits are not same.");
                        Repeat = true;
                    }
                }
            } while (Repeat);
        }
        static void Main(string[] args)
        {
            //called the methods input and output
            Input();
            Output();
            Console.ReadKey();
        }
    }
}
