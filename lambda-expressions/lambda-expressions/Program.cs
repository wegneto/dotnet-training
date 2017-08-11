using System;
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

			//Without lambda
			Division div = Divide;
			Console.WriteLine(div(2, 3));
			Console.WriteLine(div(50, 10));
		}

		public static int Divide(int x, int y)
		{
			return x / y;
		}
	}
}
