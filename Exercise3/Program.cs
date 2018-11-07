using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Vyvedi n:");
			double n = double.Parse(Console.ReadLine());
			double sum;
			int devided = 0;


			for (int i = 1; i <= n; i++)
			{
				sum = Math.Pow(i, 3) + 3 * i + n;

				if (sum % 17 == 0)
				{
					devided++;
				}
			}

			Console.WriteLine("Broi na chislata kratni na '17': {0}", devided);
		}
	}
}
