using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] array = new double[60];
			int i = 0;
			while (i < array.Length)
			{
				Console.WriteLine("Vyvedete chislo ili x za da prodyljite:");
				string respond = Console.ReadLine();

				if (respond == "x")
				{
					if (i >= 2)
					{
						break;
					}
					else
					{
						Console.WriteLine("Trqbva da vyvedete minimum 2 chisla.");
						continue;
					}
				}
				else
				{
					double crespond = double.Parse(respond);
					array[i] = crespond;
					i++;
				}
			}

			double AverageK(double[] arrayData)
			{
				Console.Write("Type k:");
				int k = int.Parse(Console.ReadLine());
				double averageSum = 0;
				double averageNumbers = 0;
				foreach (var item in arrayData)
				{
					if (item <= 10 && item >= -10)
					{
						if (item % k == 0)
						{
							averageSum += item;
							averageNumbers++;
						}
					}
				}
				return averageSum / averageNumbers;
			}

			Console.WriteLine("Average for [-10;10] in array is: {0:F2}", AverageK(array));

			double arrayMax = array.Max();
			double arrayIndexMax = array.ToList().IndexOf(arrayMax);
			Console.WriteLine("Max of typed array is:" + arrayMax + " with index " + arrayIndexMax);
		}
	}
}
