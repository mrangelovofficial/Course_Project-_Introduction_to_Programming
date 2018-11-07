using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
	class Program
	{
		static void Main(string[] args)
		{
			string fullName = Console.ReadLine();
			string[] words = fullName.Split(' ');
			Console.WriteLine(words[0][0] + ". " + words[1][0] + ". " + words[2]);
		}
	}
}
