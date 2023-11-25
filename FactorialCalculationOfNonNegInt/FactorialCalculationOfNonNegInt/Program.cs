
// Provide a solution in C# to calculate the factorial of a non-negative integer.

using System;

namespace FactorialCalculationOfNonNegInt
{
    class Program
    {

        static long CalculateFactorialOfNonNegativeInteger(long num)
        {
            long factorial = 1; // set it to 1 because 0! and 1! equal 1.
            for (int i = 2; i <= num; i++){
                factorial *= i;
            }
            return factorial;
        }


        static void Main(string[] args)
        {
            if (args.Length == 0) {
                System.Console.WriteLine("ERROR: Must Pass in 1 Argument.");
                return;
            }

            long num = Int64.Parse(args[0]);

            if (num < 0){
                System.Console.WriteLine("ERROR: Argument must be a non-negative integer.");
                return;
            }

            long factorial = CalculateFactorialOfNonNegativeInteger(num);

            Console.WriteLine("{0}'s Factorial is {1}", num, factorial);

        }

    }
    
}




