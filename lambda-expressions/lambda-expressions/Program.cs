using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace lambdaexpressions
{
	public class Program
	{
		delegate int Division(int number1, int number2);

		static void Main(string[] args)
		{
			//Using lambda
			Division divLambda = (x, y) => x / y;
			Console.WriteLine(divLambda(2, 3));
			Console.WriteLine(divLambda(50, 10));

			//Not Using lambda
			Division div = Divide;
			Console.WriteLine(div(2, 3));
			Console.WriteLine(div(50, 10));

            IEnumerable<string> values = new List<string>() { "hello", "Test 1", "Test 2", "Test 3" };
            //Using lambda
            Console.WriteLine(values.Any(s => s.Contains("hell")));
            //Not Using lambda
            foreach (string s in values) 
            {
                if (s.Contains("hell")) 
                {
                    Console.WriteLine(true);
                }    
            }
		}

		public static int Divide(int x, int y)
		{
			return x / y;
		}
	}
}
