using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Write beta value:");
			double β = double.Parse(Console.ReadLine());
			Console.Write("Write y value:");
			double y = double.Parse(Console.ReadLine());


			double eq = (β + Math.Pow(Math.Sin(Math.Pow(Math.PI, 4)), 2))
				/
				(Math.Pow(Math.Cos(6), 1.0 / 5) + Math.Abs(Math.Cos(y) / Math.Sin(y)));

			Console.WriteLine("Equation to the second sign :{0:F2}", eq);
		}
	}
}
