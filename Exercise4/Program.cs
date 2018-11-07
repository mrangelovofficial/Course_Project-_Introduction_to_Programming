using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
	class Program
	{
		static void Main(string[] args)
		{
			double param1 = 7.5;
			double param2 = 4.8;
			double param3 = 6.8;
			double areaGet;


			bool CheckValidity(double a, double b, double c)
			{
				if (a + b <= c || a + c <= b || b + c <= a)
				{
					return false;
				}
				else
				{
					return true;
				}
			}


			double returnArea(double a, double b, double c)
			{
				double s, area;

				s = (a + b + c) / 2;
				area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

				return area;
			}


			if (CheckValidity(param1, param2, param3))
			{
				areaGet = returnArea(param1, param2, param3);
				Console.WriteLine("Face of a triangle: {0:F0}", areaGet);
			}
			else
			{
				Console.WriteLine("False");
			}

		}
	
	}
}
