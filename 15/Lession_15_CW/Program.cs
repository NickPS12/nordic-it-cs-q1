using System;

namespace Lession_15_CW
{
	class Program
	{
		delegate int PerformCalculation(int[] array);

		static void Main(string[] args)
		{
			/*
			Account<int> account1 = new Account<int>(100500, "Person 01");
			account1.WriteProperties();

			Account<string> account2 = new Account<string>("str100500", "Person 02");
			account2.WriteProperties();

			Account<Guid> account3 = new Account<Guid>(Guid.NewGuid(), "Person 03");
			account3.WriteProperties();
			*/

			PerformCalculation performCalculation;

			int[] array = new [] { 12, 2, -4, 10, 54 };

			performCalculation = Sum;
			int result = performCalculation(array);
			Console.WriteLine(result);

			performCalculation = Min;
			Console.WriteLine(performCalculation(array));

			//performCalculation = Enumerable.Max;
		}

		static int Sum (int[] array)
		{
			int sum = 0;

			foreach (int i in array)
			{
				sum += i;
			}

			return sum;
		}

		static int Min (int[] array)
		{
			int min = array[0];

			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] < min)
				{
					min = array[i];
				}
			}

			return min;
		}


	}
}
