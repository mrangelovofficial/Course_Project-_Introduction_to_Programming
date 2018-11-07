using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Write x:");
			int x = int.Parse(Console.ReadLine());
			Console.Write("Write y:");
			int y = int.Parse(Console.ReadLine());
			Console.Write("Write z:");
			int z = int.Parse(Console.ReadLine());

			if (x > 0 || y > 0 || z > 0)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
		}
	}
}
