using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutParams
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int myNumber=0;     //only for 'in'
            Console.WriteLine("Enter a number : ");
            if(int.TryParse(Console.ReadLine(),out int number))    //use of int.TryParse
                myNumber = number;
            Console.WriteLine("Original number: " + myNumber);  //for 'in'
            PrintIn(in myNumber);
            Console.WriteLine("Number after 'in' function: " + myNumber);

            int result;                     //for 'out'
            CalculateSumAndProduct(5, 3, out result, out int product);
            Console.WriteLine(" after calculation in out function , Sum: " + result + ", Product: " + product);

            int sum = SumGivenParams(1, 25, 44, 4, 1);                 //for 'params'
            Console.WriteLine("After Params function ,Sum of params: " + sum);
            Console.ReadLine();
        }

        static void PrintIn(in int number)  // The parameter is read-only and cannot be modified within this function
        {
            Console.WriteLine("Inside 'in' function: " + number);
        }

        static void CalculateSumAndProduct(int a, int b, out int sum, out int product) //The parameter with out have to be modified
        {                                                                        //no return, the value of original variable will be changed 
            sum = a + b;
            product = a * b;
        }

        static int SumGivenParams(params int[] numbers)               //It will accept the n number of arguments in an array, size equals to No. of arguments
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;
            }
            return sum;
        }

    }
}
