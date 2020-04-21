using System;

namespace FibonacciRecursiv
{
	public static class FactorialHelper
	{
		//algoritm pentru calcularea Fibonacci(n)

		public static int FibonacciRecursiv(int fibonacciNr)
		{
			if (fibonacciNr <= 0)
			{
				return 0;
			}
			else if (fibonacciNr == 1)
			{
				return 1;
			}
			else
			{
				return FibonacciRecursiv(fibonacciNr - 1) + FibonacciRecursiv(fibonacciNr - 2);
			}


		}

	}		
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			Console.WriteLine(FactorialHelper.FibonacciRecursiv(7));
			Console.WriteLine();

		}
	}
}
